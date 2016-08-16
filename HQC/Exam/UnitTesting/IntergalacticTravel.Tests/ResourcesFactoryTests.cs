namespace IntergalacticTravel.Tests
{
    using Contracts;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TestFixture]
    public class ResourcesFactoryTests
    {
        [TestCase("create resources gold(20) silver(30) bronze(40)", 40, 30, 20)]
        [TestCase("create resources gold(20) bronze(40) silver(30)", 40, 30, 20)]
        [TestCase("create resources silver(30) bronze(40) gold(20)", 40, 30, 20)]
        [TestCase("create resources silver(30) gold(20) bronze(40)", 40, 30, 20)]
        [TestCase("create resources bronze(40) gold(20) silver(30)", 40, 30, 20)]
        [TestCase("create resources bronze(40) silver(30) gold(20)", 40, 30, 20)]
        public void GetResources_WhenCommandParamIsValid_ShouldReturnResources(string command, int bronze, int silver, int gold)
        {
            ResourcesFactory resourcesFactory = new ResourcesFactory();

            var resource = resourcesFactory.GetResources(command);

            Assert.IsInstanceOf<IResources>(resource);
            Assert.AreEqual(resource.BronzeCoins, (uint)bronze);
            Assert.AreEqual(resource.SilverCoins, (uint)silver);
            Assert.AreEqual(resource.GoldCoins, (uint)gold);
        }

        [TestCase("create resources x y z")]
        [TestCase("absolutelyRandomStringThatMustNotBeAValidCommand")]
        [TestCase("")]
        public void GetResources_WhenCommandParamIsInvalid_ShouldThrowInvalidOperationException(string command)
        {
            //// Arrange
            //var resourcesFactory = new IntergalacticTravel.ResourcesFactory();
            //var expectedExceptionMessage = "command";

            //// Act & Assert
            //var exc = Assert.Throws<InvalidOperationException>(
            //    () => resourcesFactory.GetResources(invalidCommand));
            //var actualExceptionMessage = exc.Message;

            //// Assert
            //StringAssert.Contains(expectedExceptionMessage, actualExceptionMessage);

            // My solution
            ResourcesFactory resourcesFactory = new ResourcesFactory();

            Assert.That(() => resourcesFactory.GetResources(command), Throws.InvalidOperationException.With.Message.Contains("command"));
        }

        [TestCase("create resources bronze(4294967296) silver(30) gold(20)")]
        [TestCase("create resources gold(4294967296) silver(30) bronze(40)")]
        [TestCase("create resources silver(4294967296) bronze(40) gold(20)")]
        public void GetResources_WhenCommandParamIsInvalid_ShouldThrowOverflowException(string command)
        {
            ResourcesFactory resourcesFactory = new ResourcesFactory();

            Assert.Throws<OverflowException>(() => resourcesFactory.GetResources(command));
        }
    }
}
