namespace IntergalacticTravel.Tests
{
    using NUnit.Framework;
    using Moq;
    using Contracts;
    using System.Collections.Generic;

    [TestFixture]
    public class BusinessOwnerTests
    {
        [Test]
        public void CollectProfits()
        {
            // Arrange           
            var listOfOwnerTeleportStations = new HashSet<ITeleportStation>() {};

            var businessOwner = new BusinessOwner(17, "ankk", listOfOwnerTeleportStations);

            var mockOwnerTeleportResource = new Mock<IResources>();
            mockOwnerTeleportResource.Setup(x => x.GoldCoins).Returns(10);
            mockOwnerTeleportResource.Setup(x => x.SilverCoins).Returns(10);
            mockOwnerTeleportResource.Setup(x => x.BronzeCoins).Returns(10);

            var mockTeleportStation = new Mock<ITeleportStation>();
            mockTeleportStation.Setup(x => x.PayProfits(businessOwner)).Returns(mockOwnerTeleportResource.Object);

            businessOwner.TeleportStations.Add(mockTeleportStation.Object);

            // Act
            businessOwner.CollectProfits();

            // Assert
            Assert.AreEqual(10, businessOwner.Resources.GoldCoins);
            Assert.AreEqual(10, businessOwner.Resources.SilverCoins);
            Assert.AreEqual(10, businessOwner.Resources.BronzeCoins);
        }
    }
}
