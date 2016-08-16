namespace IntergalacticTravel.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Moq;
    using Contracts;
    using IntergalacticTravel.Exceptions;
    using Mock;

    [TestFixture]
    public class TeleportStationTests
    {
        [Test]
        public void Constructor_WhenParamsAreValid_ShouldSetAllFieldsCorectrly()
        {
            var mockBusnessOwner = new Mock<IBusinessOwner>();
            var mockPath = new Mock<IEnumerable<IPath>>();
            var mockLocation = new Mock<ILocation>();

            var teleportStation = new MockTeleportStation(mockBusnessOwner.Object, mockPath.Object, mockLocation.Object);

            Assert.AreSame(mockBusnessOwner.Object, teleportStation.BusinessOwner);
            Assert.AreSame(mockPath.Object, teleportStation.GalacticMap);
            Assert.AreSame(mockLocation.Object, teleportStation.Location);
        }

        [Test]
        public void TeleportUnit_WhenUnitToTeleportParamIsNull_ShouldThrowArgumentNullException()
        {
            var mockBusnessOwner = new Mock<IBusinessOwner>();
            var mockPath = new Mock<IEnumerable<IPath>>();
            var mockLocation = new Mock<ILocation>();
            var mockTargetLocation = new Mock<ILocation>();

            var teleportStation = new MockTeleportStation(mockBusnessOwner.Object, mockPath.Object, mockLocation.Object);

            Assert.That(() => teleportStation.TeleportUnit(null, mockTargetLocation.Object), Throws.ArgumentNullException.With.Message.Contains("unitToTeleport"));
        }

        [Test]
        public void TeleportUnit_WhenTargetLocationParamIsNull_ShouldThrowArgumentNullException()
        {
            var mockBusnessOwner = new Mock<IBusinessOwner>();
            var mockPath = new Mock<IEnumerable<IPath>>();
            var mockLocation = new Mock<ILocation>();
            var mockUnit = new Mock<IUnit>();

            var teleportStation = new MockTeleportStation(mockBusnessOwner.Object, mockPath.Object, mockLocation.Object);

            Assert.That(() => teleportStation.TeleportUnit(mockUnit.Object, null), Throws.ArgumentNullException.With.Message.Contains("destination"));
        }

        [Test]
        public void TeleportUnit_WhenGalaxyNamesAreDifferent_ShouldThrowsTeleportOutOfRangeException()
        {
            // Arrange
            var mockBusnessOwner = new Mock<IBusinessOwner>();
            var mockPath = new Mock<IEnumerable<IPath>>();
            var mockTeleportLocation = new Mock<ILocation>();

            mockTeleportLocation.Setup(x => x.Planet.Galaxy.Name).Returns("Galaxy1");
            mockTeleportLocation.Setup(x => x.Planet.Name).Returns("Planet1");

            var mockUnitToTeleport = new Mock<IUnit>();
            var mockTargetLocation = new Mock<ILocation>();

            mockTargetLocation.Setup(x => x.Planet.Galaxy.Name).Returns("Galaxy");
            mockTargetLocation.Setup(x => x.Planet.Name).Returns("Planet");
            mockUnitToTeleport.Setup(x => x.CurrentLocation).Returns(mockTargetLocation.Object);


            var teleportStation = new MockTeleportStation(mockBusnessOwner.Object, mockPath.Object, mockTeleportLocation.Object);

            // Act & Assert
            Assert.That(() => teleportStation.TeleportUnit(mockUnitToTeleport.Object, mockTargetLocation.Object), Throws.TypeOf<TeleportOutOfRangeException>().With.Message.Contains("unitToTeleport.CurrentLocation"));
        }

        [Test]
        public void TeleportUnit_WhenPlanetNamesAreDifferent_ShouldThrowsTeleportOutOfRangeException()
        {
            // Arrange
            var mockBusnessOwner = new Mock<IBusinessOwner>();
            var mockPath = new Mock<IEnumerable<IPath>>();
            var mockLocation = new Mock<ILocation>();

            var mockUnit = new Mock<IUnit>();
            var targetLocation = new Mock<ILocation>();

            targetLocation.Setup(x => x.Planet.Galaxy.Name).Returns("GalaxyName");
            targetLocation.Setup(x => x.Planet.Name).Returns(It.IsAny<string>);
            mockUnit.Setup(x => x.CurrentLocation).Returns(targetLocation.Object);

            mockLocation.Setup(x => x.Planet.Galaxy.Name).Returns("NotGalaxyName");
            mockLocation.Setup(x => x.Planet.Name).Returns(It.IsAny<string>);

            var teleportStation = new MockTeleportStation(mockBusnessOwner.Object, mockPath.Object, mockLocation.Object);

            // Act & Assert
            Assert.That(() => teleportStation.TeleportUnit(mockUnit.Object, mockLocation.Object), Throws.TypeOf<TeleportOutOfRangeException>().With.Message.Contains("unitToTeleport.CurrentLocation"));
        }       

        [Test]
        public void TeleportUnit_WhenPlanetNamesAreDifferent_ShouldThrowsInvalidTeleportationLocationException()
        {
            // Arrange
            var mockBusnessOwner = new Mock<IBusinessOwner>();
            var mockTeleportLocation = new Mock<ILocation>();
            mockTeleportLocation.Setup(x => x.Planet.Name).Returns("P1");
            mockTeleportLocation.Setup(x => x.Planet.Galaxy.Name).Returns("G1");

            // set Galaxy path
            var mockGalaxyMap = new List<IPath>();
            var mockPath = new Mock<IPath>();

            var mockPathLocation = new Mock<ILocation>();
            mockPathLocation.Setup(x => x.Planet.Name).Returns("P1");
            mockPathLocation.Setup(x => x.Planet.Galaxy.Name).Returns("G1");

            var mockPathUnit = new Mock<IUnit>();
            mockPathLocation.Setup(x => x.Coordinates.Latitude).Returns(1);
            mockPathLocation.Setup(x => x.Coordinates.Longtitude).Returns(2);
            mockPathUnit.Setup(x => x.CurrentLocation).Returns(mockPathLocation.Object);
            mockPathLocation.Setup(x => x.Planet.Units).Returns(new List<IUnit> { mockPathUnit.Object });

            mockPath.Setup(x => x.TargetLocation).Returns(mockPathLocation.Object);
            mockGalaxyMap.Add(mockPath.Object);

            var mockUnit = new Mock<IUnit>();
            var mockUnitCurrentLocation = new Mock<ILocation>();
            var mockTargetLocation = new Mock<ILocation>();           

            var teleportStation = new MockTeleportStation(mockBusnessOwner.Object, mockGalaxyMap, mockTeleportLocation.Object);

            mockUnitCurrentLocation.Setup(x => x.Planet.Name).Returns("P1");
            mockUnitCurrentLocation.Setup(x => x.Planet.Galaxy.Name).Returns("G1");
            mockUnit.Setup(x => x.CurrentLocation).Returns(mockUnitCurrentLocation.Object);

            mockTargetLocation.Setup(x => x.Planet.Galaxy.Name).Returns("G1");
            mockTargetLocation.Setup(x => x.Planet.Name).Returns("P1");
            mockTargetLocation.Setup(x => x.Coordinates.Latitude).Returns(1);
            mockTargetLocation.Setup(x => x.Coordinates.Longtitude).Returns(2);

            // Act & Assert
            Assert.That(() => teleportStation.TeleportUnit(mockUnit.Object, mockTargetLocation.Object), Throws.TypeOf<InvalidTeleportationLocationException>().With.Message.Contains("units will overlap"));
        }

        [Test]
        public void TeleportUnit_WhenGalaxyIsNotInTeleportStationList_ShouldThrowsLocationNotFoundException()
        {
            // Arrange
            var mockBusnessOwner = new Mock<IBusinessOwner>();
            var mockTeleportLocation = new Mock<ILocation>();
            mockTeleportLocation.Setup(x => x.Planet.Name).Returns("P1");
            mockTeleportLocation.Setup(x => x.Planet.Galaxy.Name).Returns("G1");

            var mockGalaxyPath = new List<IPath>();
            var mockPath = new Mock<IPath>();
            var mockPathLocation = new Mock<ILocation>();
            mockPathLocation.Setup(x => x.Planet.Galaxy.Name).Returns("G1");
            mockPath.Setup(x => x.TargetLocation).Returns(mockPathLocation.Object);
            mockGalaxyPath.Add(mockPath.Object);                    

            var teleportStation = new MockTeleportStation(mockBusnessOwner.Object, mockGalaxyPath, mockTeleportLocation.Object);

            var mockUnit = new Mock<IUnit>();
            var mockUnitCurrentLocation = new Mock<ILocation>();
            mockUnitCurrentLocation.Setup(x => x.Planet.Name).Returns("P1");
            mockUnitCurrentLocation.Setup(x => x.Planet.Galaxy.Name).Returns("G1");
            mockUnit.Setup(x => x.CurrentLocation).Returns(mockUnitCurrentLocation.Object);

            var mockTargetLocation = new Mock<ILocation>();
            mockTargetLocation.Setup(x => x.Planet.Galaxy.Name).Returns("G2");

            // Act & Assert
            Assert.That(() => teleportStation.TeleportUnit(mockUnit.Object, mockTargetLocation.Object), Throws.TypeOf<LocationNotFoundException>().With.Message.Contains("Galaxy"));
        }
      
        [Test]
        public void TeleportUnit_WhenPlanetIsNotInTeleportStationList_ShouldThrowsLocationNotFoundException()
        {
            // Arrange
            var mockBusnessOwner = new Mock<IBusinessOwner>();
            var mockTeleportLocation = new Mock<ILocation>();
            mockTeleportLocation.Setup(x => x.Planet.Name).Returns("P1");
            mockTeleportLocation.Setup(x => x.Planet.Galaxy.Name).Returns("G1");

            var mockGalaxyPath = new List<IPath>();
            var mockPath = new Mock<IPath>();
            var mockPathLocation = new Mock<ILocation>();
            mockPathLocation.Setup(x => x.Planet.Galaxy.Name).Returns("G1");
            mockPathLocation.Setup(x => x.Planet.Name).Returns("P1");
            mockPath.Setup(x => x.TargetLocation).Returns(mockPathLocation.Object);
            mockGalaxyPath.Add(mockPath.Object);           

            var teleportStation = new MockTeleportStation(mockBusnessOwner.Object, mockGalaxyPath, mockTeleportLocation.Object);

            var mockUnit = new Mock<IUnit>();
            var mockUnitCurrentLocation = new Mock<ILocation>();
            mockUnitCurrentLocation.Setup(x => x.Planet.Name).Returns("P1");
            mockUnitCurrentLocation.Setup(x => x.Planet.Galaxy.Name).Returns("G1");
            mockUnit.Setup(x => x.CurrentLocation).Returns(mockUnitCurrentLocation.Object);

            var mockTargetLocation = new Mock<ILocation>();
            mockTargetLocation.Setup(x => x.Planet.Galaxy.Name).Returns("G1");
            mockTargetLocation.Setup(x => x.Planet.Name).Returns("P2");

            // Act & Assert
            Assert.That(() => teleportStation.TeleportUnit(mockUnit.Object, mockTargetLocation.Object), Throws.TypeOf<LocationNotFoundException>().With.Message.Contains("Planet"));
        }
      
        [Test]
        public void TeleportUnit_WhenUnitDoestHasEnoughResources_ShouldThrowInsufficientResourcesException()
        {
            // Arrange
            var mockBusnessOwner = new Mock<IBusinessOwner>();
            var mockTeleportLocation = new Mock<ILocation>();
            mockTeleportLocation.Setup(x => x.Planet.Name).Returns("P1");
            mockTeleportLocation.Setup(x => x.Planet.Galaxy.Name).Returns("G1");

            // set Galaxy path
            var mockGalaxyMap = new List<IPath>();
            var mockPath = new Mock<IPath>();

            var mockPathLocation = new Mock<ILocation>();
            mockPathLocation.Setup(x => x.Planet.Name).Returns("P1");
            mockPathLocation.Setup(x => x.Planet.Galaxy.Name).Returns("G1");

            var mockPathUnit = new Mock<IUnit>();
            mockPathLocation.Setup(x => x.Coordinates.Latitude).Returns(2);
            mockPathLocation.Setup(x => x.Coordinates.Longtitude).Returns(2);
            mockPathUnit.Setup(x => x.CurrentLocation).Returns(mockPathLocation.Object);
            mockPathLocation.Setup(x => x.Planet.Units).Returns(new List<IUnit> { mockPathUnit.Object });

            mockPath.Setup(x => x.TargetLocation).Returns(mockPathLocation.Object);

            var mockPathCost = new Mock<IResources>();
            mockPathCost.Setup(x => x.GoldCoins).Returns(10);
            mockPathCost.Setup(x => x.SilverCoins).Returns(10);
            mockPathCost.Setup(x => x.BronzeCoins).Returns(10);
            mockPath.Setup(x => x.Cost).Returns(mockPathCost.Object);

            mockGalaxyMap.Add(mockPath.Object);

            // Act
            var teleportStation = new MockTeleportStation(mockBusnessOwner.Object, mockGalaxyMap, mockTeleportLocation.Object);

            // unit to teleport            
            var mockUnitToTeleport = new Mock<IUnit>();
            var mockUnitToTeleportCurrentLocation = new Mock<ILocation>();
            mockUnitToTeleportCurrentLocation.Setup(x => x.Planet.Name).Returns("P1");
            mockUnitToTeleportCurrentLocation.Setup(x => x.Planet.Galaxy.Name).Returns("G1");

            mockUnitToTeleport.Setup(x => x.CurrentLocation).Returns(mockUnitToTeleportCurrentLocation.Object);

            var mockUnitToTeleportResources = new Mock<IResources>();          

            mockUnitToTeleport.Setup(x => x.Resources).Returns(mockUnitToTeleportResources.Object);           
            mockUnitToTeleport.Setup(x => x.CanPay(mockPathCost.Object)).Returns(false);

            // target location
            var mockTargetLocation = new Mock<ILocation>();
            mockTargetLocation.Setup(x => x.Planet.Galaxy.Name).Returns("G1");
            mockTargetLocation.Setup(x => x.Planet.Name).Returns("P1");
            mockTargetLocation.Setup(x => x.Coordinates.Latitude).Returns(1);
            mockTargetLocation.Setup(x => x.Coordinates.Longtitude).Returns(2);

            // Act & Assert
            Assert.That(() => teleportStation.TeleportUnit(mockUnitToTeleport.Object, mockTargetLocation.Object), Throws.TypeOf<InsufficientResourcesException>().With.Message.Contains("FREE LUNCH"));
        }
       
        [Test]
        public void TeleportUnit_WhenUnitIsReadyToTeleport_ShouldObtainPayment()
        {
            // Arrange
            var mockBusnessOwner = new Mock<IBusinessOwner>();
            var mockTeleportLocation = new Mock<ILocation>();
            mockTeleportLocation.Setup(x => x.Planet.Name).Returns("P1");
            mockTeleportLocation.Setup(x => x.Planet.Galaxy.Name).Returns("G1");

            // set Galaxy path
            var mockGalaxyMap = new List<IPath>();
            var mockPath = new Mock<IPath>();

            var mockPathLocation = new Mock<ILocation>();
            mockPathLocation.Setup(x => x.Planet.Name).Returns("P1");
            mockPathLocation.Setup(x => x.Planet.Galaxy.Name).Returns("G1");

            var mockPathUnit = new Mock<IUnit>();
            mockPathLocation.Setup(x => x.Coordinates.Latitude).Returns(2);
            mockPathLocation.Setup(x => x.Coordinates.Longtitude).Returns(2);
            mockPathUnit.Setup(x => x.CurrentLocation).Returns(mockPathLocation.Object);
            mockPathLocation.Setup(x => x.Planet.Units).Returns(new List<IUnit> { mockPathUnit.Object });

            mockPath.Setup(x => x.TargetLocation).Returns(mockPathLocation.Object);

            var mockPathCost = new Mock<IResources>();
            mockPathCost.Setup(x => x.GoldCoins).Returns(10);
            mockPathCost.Setup(x => x.SilverCoins).Returns(10);
            mockPathCost.Setup(x => x.BronzeCoins).Returns(10);
            mockPath.Setup(x => x.Cost).Returns(mockPathCost.Object);

            mockGalaxyMap.Add(mockPath.Object);

            var teleportStation = new MockTeleportStation(mockBusnessOwner.Object, mockGalaxyMap, mockTeleportLocation.Object);

            // unit to teleport            
            var mockUnitToTeleport = new Mock<IUnit>();
            var mockUnitToTeleportCurrentLocation = new Mock<ILocation>();
            mockUnitToTeleportCurrentLocation.Setup(x => x.Planet.Name).Returns("P1");
            mockUnitToTeleportCurrentLocation.Setup(x => x.Planet.Galaxy.Name).Returns("G1");
            mockUnitToTeleportCurrentLocation.Setup(x => x.Planet.Units).Returns(new List<IUnit>());

            mockUnitToTeleport.Setup(x => x.CurrentLocation).Returns(mockUnitToTeleportCurrentLocation.Object);

            var mockUnitToTeleportResources = new Mock<IResources>();
            mockUnitToTeleportResources.Setup(x => x.GoldCoins).Returns(11);
            mockUnitToTeleportResources.Setup(x => x.SilverCoins).Returns(11);
            mockUnitToTeleportResources.Setup(x => x.BronzeCoins).Returns(11);
            mockUnitToTeleport.Setup(x => x.Resources).Returns(mockUnitToTeleportResources.Object);
            mockUnitToTeleport.Setup(x => x.CanPay(It.IsAny<IResources>())).Returns(true);
            mockUnitToTeleport.Setup(x => x.Pay(mockPathCost.Object)).Returns(mockPathCost.Object);

            // target location
            var mockTargetLocation = new Mock<ILocation>();
            mockTargetLocation.Setup(x => x.Planet.Galaxy.Name).Returns("G1");
            mockTargetLocation.Setup(x => x.Planet.Name).Returns("P1");
            mockTargetLocation.Setup(x => x.Coordinates.Latitude).Returns(1);
            mockTargetLocation.Setup(x => x.Coordinates.Longtitude).Returns(2);

            teleportStation.TeleportUnit(mockUnitToTeleport.Object, mockTargetLocation.Object);

            mockUnitToTeleport.Verify(x => x.Pay(mockPathCost.Object), Times.Once);
        }

        [Test]
        public void TeleportUnit_WhenUnitIsReadyToTeleport_ShouldIncreseTeleportStationResources()
        {
            // Arrange
            var mockBusnessOwner = new Mock<IBusinessOwner>();
            var mockTeleportLocation = new Mock<ILocation>();
            mockTeleportLocation.Setup(x => x.Planet.Name).Returns("P1");
            mockTeleportLocation.Setup(x => x.Planet.Galaxy.Name).Returns("G1");

            // set Galaxy path
            var mockGalaxyMap = new List<IPath>();
            var mockPath = new Mock<IPath>();

            var mockPathLocation = new Mock<ILocation>();
            mockPathLocation.Setup(x => x.Planet.Name).Returns("P1");
            mockPathLocation.Setup(x => x.Planet.Galaxy.Name).Returns("G1");

            var mockPathUnit = new Mock<IUnit>();
            mockPathLocation.Setup(x => x.Coordinates.Latitude).Returns(2);
            mockPathLocation.Setup(x => x.Coordinates.Longtitude).Returns(2);
            mockPathUnit.Setup(x => x.CurrentLocation).Returns(mockPathLocation.Object);
            mockPathLocation.Setup(x => x.Planet.Units).Returns(new List<IUnit> { mockPathUnit.Object });

            mockPath.Setup(x => x.TargetLocation).Returns(mockPathLocation.Object);

            var mockPathCost = new Mock<IResources>();
            mockPathCost.Setup(x => x.GoldCoins).Returns(10);
            mockPathCost.Setup(x => x.SilverCoins).Returns(10);
            mockPathCost.Setup(x => x.BronzeCoins).Returns(10);
            mockPath.Setup(x => x.Cost).Returns(mockPathCost.Object);

            mockGalaxyMap.Add(mockPath.Object);

            var teleportStation = new MockTeleportStation(mockBusnessOwner.Object, mockGalaxyMap, mockTeleportLocation.Object);

            // unit to teleport            
            var mockUnitToTeleport = new Mock<IUnit>();
            var mockUnitToTeleportCurrentLocation = new Mock<ILocation>();
            mockUnitToTeleportCurrentLocation.Setup(x => x.Planet.Name).Returns("P1");
            mockUnitToTeleportCurrentLocation.Setup(x => x.Planet.Galaxy.Name).Returns("G1");
            mockUnitToTeleportCurrentLocation.Setup(x => x.Planet.Units).Returns(new List<IUnit>());

            mockUnitToTeleport.Setup(x => x.CurrentLocation).Returns(mockUnitToTeleportCurrentLocation.Object);

            var mockUnitToTeleportResources = new Mock<IResources>();
            mockUnitToTeleportResources.Setup(x => x.GoldCoins).Returns(11);
            mockUnitToTeleportResources.Setup(x => x.SilverCoins).Returns(11);
            mockUnitToTeleportResources.Setup(x => x.BronzeCoins).Returns(11);
            mockUnitToTeleport.Setup(x => x.Resources).Returns(mockUnitToTeleportResources.Object);
            mockUnitToTeleport.Setup(x => x.CanPay(mockPathCost.Object)).Returns(true);
            mockUnitToTeleport.Setup(x => x.Pay(mockPathCost.Object)).Returns(mockPathCost.Object);

            // target location
            var mockTargetLocation = new Mock<ILocation>();
            mockTargetLocation.Setup(x => x.Planet.Galaxy.Name).Returns("G1");
            mockTargetLocation.Setup(x => x.Planet.Name).Returns("P1");
            mockTargetLocation.Setup(x => x.Coordinates.Latitude).Returns(1);
            mockTargetLocation.Setup(x => x.Coordinates.Longtitude).Returns(2);

            // Act
            teleportStation.TeleportUnit(mockUnitToTeleport.Object, mockTargetLocation.Object);

            // Assert
            Assert.AreEqual(10, teleportStation.Resources.GoldCoins);
            Assert.AreEqual(10, teleportStation.Resources.SilverCoins);
            Assert.AreEqual(10, teleportStation.Resources.BronzeCoins);
        }

        [Test]
        public void TeleportUnit_WhenUnitIsTeleported_ShouldSetCorrectlyUnitPreviousLocationToCurrent()
        {
            // Arrange
            var planetName = "P1";
            var galaxyName = "G1";
            var longtitude = 45d;
            var latitude = 45d;

            var teleportStationLocationMock = new Mock<ILocation>();
            var teleportStationOwnerMock = new Mock<IBusinessOwner>();
            var teleportStationMapMock = new List<IPath>();

            var pathMock = new Mock<IPath>();
            var planetaryUnitMock = new Mock<IUnit>();

            planetaryUnitMock.Setup(x => x.CurrentLocation.Planet.Name).Returns(planetName);
            planetaryUnitMock.Setup(x => x.CurrentLocation.Planet.Galaxy.Name).Returns(galaxyName);
            planetaryUnitMock.Setup(x => x.CurrentLocation.Coordinates.Latitude).Returns(latitude + 15d);
            planetaryUnitMock.Setup(x => x.CurrentLocation.Coordinates.Longtitude).Returns(longtitude + 15d);

            var planetaryUnitsList = new List<IUnit> { planetaryUnitMock.Object };
            
            pathMock.Setup(x => x.Cost.BronzeCoins).Returns(10);
            pathMock.Setup(x => x.Cost.SilverCoins).Returns(10);
            pathMock.Setup(x => x.Cost.GoldCoins).Returns(10);
            pathMock.Setup(x => x.TargetLocation.Planet.Name).Returns(planetName);
            pathMock.Setup(x => x.TargetLocation.Planet.Galaxy.Name).Returns(galaxyName);
            pathMock.Setup(x => x.TargetLocation.Planet.Units).Returns(planetaryUnitsList);

            var unitToTeleportMock = new Mock<IUnit>();
            var currentUnitLocationPlanetaryUnitsList = new List<IUnit> { unitToTeleportMock.Object };

            teleportStationMapMock.Add(pathMock.Object);
            var teleportStation = new MockTeleportStation(teleportStationOwnerMock.Object, teleportStationMapMock, teleportStationLocationMock.Object);

            unitToTeleportMock.Setup(x => x.CurrentLocation.Planet.Name).Returns(planetName);
            unitToTeleportMock.Setup(x => x.CurrentLocation.Planet.Galaxy.Name).Returns(galaxyName);
            unitToTeleportMock.Setup(x => x.CurrentLocation.Coordinates.Latitude).Returns(latitude);
            unitToTeleportMock.Setup(x => x.CurrentLocation.Coordinates.Longtitude).Returns(longtitude);
            unitToTeleportMock.Setup(x => x.CanPay(It.IsAny<IResources>())).Returns(true);
            unitToTeleportMock.Setup(x => x.Pay(pathMock.Object.Cost)).Returns(pathMock.Object.Cost);
            unitToTeleportMock.Setup(x => x.CurrentLocation.Planet.Units).Returns(currentUnitLocationPlanetaryUnitsList);

            var targetLocationMock = new Mock<ILocation>();
            targetLocationMock.Setup(x => x.Planet.Name).Returns(planetName);
            targetLocationMock.Setup(x => x.Planet.Galaxy.Name).Returns(galaxyName);
            targetLocationMock.Setup(x => x.Coordinates.Latitude).Returns(latitude);
            targetLocationMock.Setup(x => x.Coordinates.Longtitude).Returns(longtitude);

            teleportStationLocationMock.Setup(x => x.Planet.Name).Returns(planetName);
            teleportStationLocationMock.Setup(x => x.Planet.Galaxy.Name).Returns(galaxyName);

            // Act
            teleportStation.TeleportUnit(unitToTeleportMock.Object, targetLocationMock.Object);

            // Assert
            unitToTeleportMock.VerifySet(x => x.PreviousLocation = x.CurrentLocation, Times.Once());
        }

        //TeleportUnit should Set the unitToTeleport's current location to targetLocation, when all of the validations pass successfully and the unit is being teleported.

        [Test]
        public void TeleportUnit_WhenValidationsPass_ShouldSetUnitCurrentLocationToTargetLocation()
        {
            // Arrange
            var planetName = "P1";
            var galaxyName = "G1";
            var longtitude = 45d;
            var latitude = 45d;

            var teleportStationLocationMock = new Mock<ILocation>();
            var teleportStationOwnerMock = new Mock<IBusinessOwner>();
            var teleportStationMapMock = new List<IPath>();

            var pathMock = new Mock<IPath>();
            var planetaryUnitMock = new Mock<IUnit>();

            planetaryUnitMock.Setup(x => x.CurrentLocation.Planet.Name).Returns(planetName);
            planetaryUnitMock.Setup(x => x.CurrentLocation.Planet.Galaxy.Name).Returns(galaxyName);
            planetaryUnitMock.Setup(x => x.CurrentLocation.Coordinates.Latitude).Returns(latitude + 15d);
            planetaryUnitMock.Setup(x => x.CurrentLocation.Coordinates.Longtitude).Returns(longtitude + 15d);

            var planetaryUnitsList = new List<IUnit> { planetaryUnitMock.Object };

            pathMock.Setup(x => x.Cost.BronzeCoins).Returns(10);
            pathMock.Setup(x => x.Cost.SilverCoins).Returns(10);
            pathMock.Setup(x => x.Cost.GoldCoins).Returns(10);
            pathMock.Setup(x => x.TargetLocation.Planet.Name).Returns(planetName);
            pathMock.Setup(x => x.TargetLocation.Planet.Galaxy.Name).Returns(galaxyName);
            pathMock.Setup(x => x.TargetLocation.Planet.Units).Returns(planetaryUnitsList);

            var unitToTeleportMock = new Mock<IUnit>();
            var currentUnitLocationPlanetaryUnitsList = new List<IUnit> { unitToTeleportMock.Object };

            teleportStationMapMock.Add(pathMock.Object);

            var teleportStation = new MockTeleportStation(teleportStationOwnerMock.Object, teleportStationMapMock, teleportStationLocationMock.Object);

            unitToTeleportMock.Setup(x => x.CurrentLocation.Planet.Name).Returns(planetName);
            unitToTeleportMock.Setup(x => x.CurrentLocation.Planet.Galaxy.Name).Returns(galaxyName);
            unitToTeleportMock.Setup(x => x.CurrentLocation.Coordinates.Latitude).Returns(latitude);
            unitToTeleportMock.Setup(x => x.CurrentLocation.Coordinates.Longtitude).Returns(longtitude);
            unitToTeleportMock.Setup(x => x.CanPay(It.IsAny<IResources>())).Returns(true);
            unitToTeleportMock.Setup(x => x.Pay(pathMock.Object.Cost)).Returns(pathMock.Object.Cost);
            unitToTeleportMock.Setup(x => x.CurrentLocation.Planet.Units).Returns(currentUnitLocationPlanetaryUnitsList);

            var targetLocationMock = new Mock<ILocation>();
            targetLocationMock.Setup(x => x.Planet.Name).Returns(planetName);
            targetLocationMock.Setup(x => x.Planet.Galaxy.Name).Returns(galaxyName);
            targetLocationMock.Setup(x => x.Coordinates.Latitude).Returns(latitude);
            targetLocationMock.Setup(x => x.Coordinates.Longtitude).Returns(longtitude);

            teleportStationLocationMock.Setup(x => x.Planet.Name).Returns(planetName);
            teleportStationLocationMock.Setup(x => x.Planet.Galaxy.Name).Returns(galaxyName);

            // Act
            teleportStation.TeleportUnit(unitToTeleportMock.Object, targetLocationMock.Object);

            // Assert
            unitToTeleportMock.VerifySet(x => x.CurrentLocation = targetLocationMock.Object, Times.Once());
        }
    }
}
