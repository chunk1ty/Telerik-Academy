namespace ExposeInternals.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SummatorUnitTests
    {
        [TestMethod]
        public void SumTwoPlusTwoShouldEqualFour()
        {
            var summator = new Summator();
            var result = summator.Sum(2, 2);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void SumMinusOneAndMinusOneShouldEqualMinusTwo()
        {
            var summator = new Summator();
            var result = summator.Sum(-1, -1);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void SumInt32MaxValueAndInt32MaxValueShouldProduceCorrectResult()
        {
            var summator = new Summator();
            var result = summator.Sum(int.MaxValue, int.MaxValue);
            Assert.AreEqual((long)int.MaxValue + int.MaxValue, result);
        }

        [TestMethod]
        public void SumInt32MaxValueAndInt32MinValueShouldEqualMinusOne()
        {
            var summator = new Summator();
            var result = summator.Sum(int.MaxValue, int.MinValue);
            Assert.AreEqual(-1, result);
        }

        // GetZero
        [TestMethod]
        public void GetZeroReturnsZero()
        {
            var summator = new Summator();
            var privateObject = new PrivateObject(summator);
            var getZeroValue = privateObject.Invoke("GetZero");
            Assert.AreEqual(0, getZeroValue);
        }
    }
}
