namespace IntergalacticTravel.Tests
{
    using Exceptions;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TestFixture]
    public class UnitsFactoryTests
    {
        [Test]
        public void GetUnit_WhenValidCommandIsPassed_ShouldReturnProcyonUnit()
        {
            // Arrange
            string cmd = "create unit Procyon Gosho 1";
            UnitsFactory unitsFactory = new UnitsFactory();

            // Act & Assert
            Assert.IsInstanceOf<Procyon>(unitsFactory.GetUnit(cmd));
        }

        [Test]
        public void GetUnit_WhenValidCommandIsPassed_ShouldReturnLuytenUnit()
        {
            // Arrange
            string cmd = "create unit Luyten Pesho 2";
            UnitsFactory unitsFactory = new UnitsFactory();

            // Act & Assert
            Assert.IsInstanceOf<Luyten>(unitsFactory.GetUnit(cmd));
        }

        [Test]
        public void GetUnit_WhenValidCommandIsPassed_ShouldReturnLacailleUnit()
        {
            // Arrange
            string cmd = "create unit Lacaille Tosho 3";
            UnitsFactory unitsFactory = new UnitsFactory();

            // Act & Assert
            Assert.IsInstanceOf<Lacaille>(unitsFactory.GetUnit(cmd));
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("create unit InvalidUnitType Tosho 3")]
        public void GetUnit_WhenInvalidCommandIsPassed_ShouldThrowInvalidUnitCreationCommandException(string cmd)
        {
            // Arrange          
            UnitsFactory unitsFactory = new UnitsFactory();

            // Act & Assert
            Assert.Throws<InvalidUnitCreationCommandException>(() => unitsFactory.GetUnit(cmd));
        }
    }
}
