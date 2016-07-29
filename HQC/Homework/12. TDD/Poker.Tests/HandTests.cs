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
    public class HandTests
    {
        [Test]       
        public void HandShouldReturnCorrectToString()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Spades)
            };

            var hand = new Hand(cards);

            string expectedHandToString = "Ace Diamonds | Eight Hearts | Nine Spades";

            Assert.AreEqual(expectedHandToString, hand.ToString());
        }

        [Test]
        public void HandShouldThrowArgumentNullExceptionWhenContainsNullCard()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Diamonds),
                null,
                new Card(CardFace.Nine, CardSuit.Spades)
            };

            Assert.Throws<ArgumentNullException>(() => new Hand(cards));
        }

        [Test]
        public void HandShouldThrowArgumentNullException()
        {
            IList<ICard> cards = null;

            Assert.Throws<ArgumentNullException>(() => new Hand(cards));
        }

        [Test]
        public void HandShouldBeEmpty()
        {
            IList<ICard> cards = new List<ICard>();

            var hand = new Hand(cards);

            string expectedHandToString = "The hand is empty";

            Assert.AreEqual(expectedHandToString, hand.ToString());
        }
    }
}
