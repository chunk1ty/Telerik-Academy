namespace Poker.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using NUnit.Framework;

    using Poker;

    [TestFixture]
    public class CardTests
    {
        [TestCase(CardFace.Ace, CardSuit.Clubs, "Ace Clubs")]
        [TestCase(CardFace.Two, CardSuit.Diamonds, "Two Diamonds")]
        [TestCase(CardFace.Eight, CardSuit.Hearts, "Eight Hearts")]
        [TestCase(CardFace.Jack, CardSuit.Spades, "Jack Spades")]
        public void CardShouldReturnCorrectToString(CardFace cardFace, CardSuit cardSuit, string expected)
        {
            var card = new Card(cardFace, cardSuit);

            string actualCardToString = card.ToString();

            Assert.AreEqual(expected, actualCardToString);
        }
    }
}
