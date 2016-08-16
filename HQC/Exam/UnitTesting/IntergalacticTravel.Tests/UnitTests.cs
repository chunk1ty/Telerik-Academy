namespace IntergalacticTravel.Tests
{
    using Contracts;
    using Mock;
    using Moq;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void Pay_WhenCostParamIsNull_ShouldThrowNullReferenceException()
        {
            //Arrange
            Unit unit = new Unit(1, "ankk");

            //Act & Asser
            Assert.Throws<NullReferenceException>(() => unit.Pay(null));
        }
        
        [Test]
        public void Pay_WhenCostParamIsValid_ShouldDecreasseAmountOfResources()
        {
            //Arrange 
            var unit = new Unit(1, "ankk");

            var mockUnitResources = new Mock<IResources>();
            mockUnitResources.Setup(x => x.GoldCoins).Returns(10);
            mockUnitResources.Setup(x => x.SilverCoins).Returns(10);
            mockUnitResources.Setup(x => x.BronzeCoins).Returns(10);

            unit.Resources.Add(mockUnitResources.Object);

            var mockCostResources = new Mock<IResources>();
            mockCostResources.Setup(x => x.GoldCoins).Returns(5);
            mockCostResources.Setup(x => x.SilverCoins).Returns(5);
            mockCostResources.Setup(x => x.BronzeCoins).Returns(5);

            //Act
            unit.Pay(mockCostResources.Object);

            //Assert
            Assert.AreEqual(5, unit.Resources.GoldCoins);
            Assert.AreEqual(5, unit.Resources.SilverCoins);
            Assert.AreEqual(5, unit.Resources.BronzeCoins);
        }

        [Test]
        public void Pay_WhenCostParamIsValid_ShouldReturnResource()
        {
            //Arrange
            IUnit unit = new Unit(1, "ankk");

            var mockUnitResources = new Mock<IResources>();
            mockUnitResources.Setup(x => x.GoldCoins).Returns(10);
            mockUnitResources.Setup(x => x.SilverCoins).Returns(10);
            mockUnitResources.Setup(x => x.BronzeCoins).Returns(10);
            
            //Act
            var payResult = unit.Pay(mockUnitResources.Object);

            //Assert
            Assert.IsInstanceOf<Resources>(payResult);
            Assert.AreEqual(10, payResult.GoldCoins);
            Assert.AreEqual(10, payResult.BronzeCoins);
            Assert.AreEqual(10, payResult.SilverCoins);
        }
    }
}
