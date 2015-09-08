using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;

namespace Poker.Test
{
    [TestClass]
    public class HandTests
    {
        [TestMethod]
        public void HandShouldReturnToStringCorrectly()
        {
            IList<ICard> cards = new List<ICard> 
           {
               new Card(CardFace.Queen,CardSuit.Clubs),
               new Card(CardFace.Nine,CardSuit.Hearts),
               new Card(CardFace.Queen,CardSuit.Diamonds),
               new Card(CardFace.Queen,CardSuit.Spades),
           };
            var hand = new Hand(cards);

            var expected = "Queen of Clubs | Nine of Hearts | Queen of Diamonds | Queen of Spades";

            Assert.AreEqual(expected, hand.ToString());
        }
    }
}
