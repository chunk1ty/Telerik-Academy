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
    public class PokerHandsCheckerTests
    {
        [Test]
        public void IsValidHand_Should_ReturnTrue()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Spades)
            };
            var hand = new Hand(cards);
            var pokerHand = new PokerHandsChecker();

            pokerHand.IsValidHand(hand);

            Assert.IsTrue(pokerHand.IsValidHand(hand));
        }

        [Test]
        public void IsValidHand_Should_ReturnFalse()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Spades)
            };
            var hand = new Hand(cards);
            var pokerHand = new PokerHandsChecker();

            pokerHand.IsValidHand(hand);

            Assert.IsFalse(pokerHand.IsValidHand(hand));
        }

        [Test]
        public void IsValidHand_ContainsExactly5Cards()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Diamonds)
            };
            var hand = new Hand(cards);
            var pokerHand = new PokerHandsChecker();

            pokerHand.IsValidHand(hand);

            Assert.AreEqual(5, cards.Count);
        }

        [Test]
        public void IsValidHand_ThrowsArgumentExceptionWhenDoesNotContains5Cards()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Spades),
            };
            var hand = new Hand(cards);
            var pokerHand = new PokerHandsChecker();

            Assert.Throws<ArgumentException>(() => pokerHand.IsValidHand(hand));
        }

        [Test]
        public void IsValidHand_ThrowArgumentNullExceptionWhenHandIsNull()
        {
            var pokerHandChecker = new PokerHandsChecker();
            IHand hand = null;

            Assert.Throws<ArgumentNullException>(() => pokerHandChecker.IsValidHand(hand));
        }

        [Test]
        public void IsValidHandShouldReturnFalseWithFiveCardsOfSameFace()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Hearts)
            };
            var hand = new Hand(cards);

            Assert.IsFalse(checker.IsValidHand(hand));
        }

        [Test]
        public void IsFlush_ShouldThrowArgumentNullExceptionWhenHandIsNull()
        {
            var pokerHandChecker = new PokerHandsChecker();
            IHand hand = null;

            Assert.Throws<ArgumentNullException>(() => pokerHandChecker.IsFlush(hand));
        }

        [Test]
        public void IsFlush_SpadesFlush_ShouldReturnTrue()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Spades),
            };

            var hand = new Hand(cards);
            var pokerHand = new PokerHandsChecker();

            Assert.IsTrue(pokerHand.IsFlush(hand));
        }

        [Test]
        public void IsFlush_HeartsFlush_ShouldReturnTrue()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Hearts),
            };

            var hand = new Hand(cards);
            var pokerHand = new PokerHandsChecker();

            Assert.IsTrue(pokerHand.IsFlush(hand));
        }

        [Test]
        public void IsFlush_ShouldReturnFalse()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Hearts),
            };

            var hand = new Hand(cards);
            var pokerHand = new PokerHandsChecker();

            Assert.IsFalse(pokerHand.IsFlush(hand));
        }

        private static object[] _sourceLists =
        {
            new object[]
            {
                 new List<ICard>()
                {
                    new Card(CardFace.Nine, CardSuit.Hearts),
                    new Card(CardFace.Ace, CardSuit.Hearts),
                    new Card(CardFace.Ace, CardSuit.Clubs),
                    new Card(CardFace.Ace, CardSuit.Diamonds),
                    new Card(CardFace.Ace, CardSuit.Spades),
                }
            }, 
            new object[]
            {
                 new List<ICard>()
                {
                    new Card(CardFace.Ace, CardSuit.Hearts),
                    new Card(CardFace.Nine, CardSuit.Hearts),
                    new Card(CardFace.Ace, CardSuit.Clubs),
                    new Card(CardFace.Ace, CardSuit.Diamonds),
                    new Card(CardFace.Ace, CardSuit.Spades),
                }
            },
            new object[]
            {
                 new List<ICard>()
                {
                    new Card(CardFace.Ace, CardSuit.Hearts),
                    new Card(CardFace.Ace, CardSuit.Clubs),
                    new Card(CardFace.Nine, CardSuit.Hearts),
                    new Card(CardFace.Ace, CardSuit.Diamonds),
                    new Card(CardFace.Ace, CardSuit.Spades),
                }
            },
            new object[]
            {
                 new List<ICard>()
                {
                    new Card(CardFace.Ace, CardSuit.Hearts),
                    new Card(CardFace.Ace, CardSuit.Clubs),
                    new Card(CardFace.Ace, CardSuit.Diamonds),
                    new Card(CardFace.Nine, CardSuit.Hearts),
                    new Card(CardFace.Ace, CardSuit.Spades),
                }
            },
            new object[]
            {
                 new List<ICard>()
                {
                    new Card(CardFace.Ace, CardSuit.Hearts),
                    new Card(CardFace.Ace, CardSuit.Clubs),
                    new Card(CardFace.Ace, CardSuit.Diamonds),
                    new Card(CardFace.Ace, CardSuit.Spades),
                    new Card(CardFace.Nine, CardSuit.Hearts),
                }
            }
        };

        [Test, TestCaseSource("_sourceLists")]
        public void IsFourOfAKind_ShouldReturnTrue(List<ICard> cards)
        {
            var hand = new Hand(cards);
            var pokerHand = new PokerHandsChecker();

            Assert.IsTrue(pokerHand.IsFourOfAKind(hand));
        }

        [Test]
        public void IsFourOfAKind_ShouldReturnFalse()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Hearts),
            };

            var hand = new Hand(cards);
            var pokerHand = new PokerHandsChecker();

            Assert.IsFalse(pokerHand.IsFourOfAKind(hand));
        }

        [Test]
        public void IsHighCard_HaveFlush_ShouldReturnFalse()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Hearts),
            };

            var hand = new Hand(cards);
            var pokerHand = new PokerHandsChecker();

            Assert.IsFalse(pokerHand.IsHighCard(hand));
        }

        [Test]
        public void IsHighCard_ShouldReturnFalse()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Clubs),
            };

            var hand = new Hand(cards);
            var pokerHand = new PokerHandsChecker();

            Assert.IsFalse(pokerHand.IsHighCard(hand));
        }

        [Test]
        public void IsHighCard_ShouldReturnTrue()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Clubs),
            };

            var hand = new Hand(cards);
            var pokerHand = new PokerHandsChecker();

            Assert.IsTrue(pokerHand.IsHighCard(hand));
        }

        [Test]
        public void IsOnePair_ShouldReturnTrue()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Clubs),
            };

            var hand = new Hand(cards);
            var pokerHand = new PokerHandsChecker();

            Assert.IsTrue(pokerHand.IsOnePair(hand));
        }

        [Test]
        public void IsOnePair_ShouldReturnFalse()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Clubs),
            };

            var hand = new Hand(cards);
            var pokerHand = new PokerHandsChecker();

            Assert.IsFalse(pokerHand.IsOnePair(hand));
        }

        [Test]
        public void IsTwoPair_ShouldReturnTrue()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Clubs),
            };

            var hand = new Hand(cards);
            var pokerHand = new PokerHandsChecker();

            Assert.IsTrue(pokerHand.IsTwoPair(hand));
        }

        [Test]
        public void IsTwoPair_ShouldReturnFalse()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Clubs),
            };

            var hand = new Hand(cards);
            var pokerHand = new PokerHandsChecker();

            Assert.IsFalse(pokerHand.IsTwoPair(hand));
        }

        [Test]
        public void IsThreeOfAKind_ShouldReturnFalse()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Clubs),
            };

            var hand = new Hand(cards);
            var pokerHand = new PokerHandsChecker();

            Assert.IsFalse(pokerHand.IsThreeOfAKind(hand));
        }

        [Test]
        public void IsThreeOfAKind_ShouldReturnTrue()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Clubs),
            };

            var hand = new Hand(cards);
            var pokerHand = new PokerHandsChecker();

            Assert.IsTrue(pokerHand.IsThreeOfAKind(hand));
        }

        [Test]
        public void IsFullHouse_ShouldReturnFalse()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Clubs),
            };

            var hand = new Hand(cards);
            var pokerHand = new PokerHandsChecker();

            Assert.IsFalse(pokerHand.IsFullHouse(hand));
        }

        [Test]
        public void IsFullHouse_ShouldReturnTrue()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Clubs),
            };

            var hand = new Hand(cards);
            var pokerHand = new PokerHandsChecker();

            Assert.IsTrue(pokerHand.IsFullHouse(hand));
        }

        [Test]
        public void IsStraight_ShouldReturnFalse()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Clubs),
            };

            var hand = new Hand(cards);
            var pokerHand = new PokerHandsChecker();

            Assert.IsFalse(pokerHand.IsStraight(hand));
        }

        [Test]
        public void IsStraight_ShouldReturnTrue()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Clubs),
            };

            var hand = new Hand(cards);
            var pokerHand = new PokerHandsChecker();

            Assert.IsTrue(pokerHand.IsStraight(hand));
        }

        [Test]
        public void IsStraightFlush_ShouldReturnFalse()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Clubs),
            };

            var hand = new Hand(cards);
            var pokerHand = new PokerHandsChecker();

            Assert.IsFalse(pokerHand.IsStraightFlush(hand));
        }

        [Test]
        public void IsStraightFlush_ShouldReturnTrue()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Hearts),
            };

            var hand = new Hand(cards);
            var pokerHand = new PokerHandsChecker();

            Assert.IsTrue(pokerHand.IsStraightFlush(hand));
        }
    }
}
