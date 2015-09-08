using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker.Test
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void CardShouldReturnToStringCorrectly()
        {
            var card = new Card(CardFace.Queen, CardSuit.Spades);
            var expected = "Queen of Spades";

            Assert.AreEqual(expected, card.ToString());
        }
    }
}
