using System;
using System.Linq;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException();
            }

            if (hand.Cards.Count != 5)
            {
                throw new ArgumentException();
            }

            if (hand.Cards.Distinct().Count() != 5)
            {
                return false;
            }
            
            //for (int i = 0; i < hand.Cards.Count - 1; i++)
            //{
            //    for (int j = i + 1; j < hand.Cards.Count; j++)
            //    {
            //        if (hand.Cards[i].Equals(hand.Cards[j]))
            //        {
            //            return false;
            //        }
            //    }
            //}

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            var groupCards = hand.Cards
               .OrderBy(x => x.Face)
               .Select(
                   x => new
                   {
                       Face = x.Face,
                       CardSuit = x.Suit
                   }
               ).ToList();

            int counter = 0;
            for (int i = 0; i < groupCards.Count() - 1; i++)
            {
                if (((groupCards[i].Face + 1) == groupCards[i + 1].Face) &&
                    (groupCards[i].CardSuit == groupCards[i + 1].CardSuit))
                {
                    counter++;
                }
            }

            return counter == 4 ? true : false;
        }

        public bool IsFourOfAKind(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            var group = hand.Cards.GroupBy(x => x.Face);

            return group.Count() == 2 && group.Any(x => x.Count() == 4);
        }

        public bool IsFullHouse(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            var groups = hand.Cards.GroupBy(x => x.Face);

            return groups.Count() == 2 && groups.Any(x => x.Count() == 3);
        }

        public bool IsFlush(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            if (this.IsStraightFlush(hand))
            {
                return false;
            }

            var firstCard = hand.Cards[0];

            for (int i = 1; i < hand.Cards.Count; i++)
            {
                if (firstCard.Suit != hand.Cards[i].Suit)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsStraight(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            var groupCards = hand.Cards
                .OrderBy(x => x.Face)
                .Select(
                    x => new
                    {
                        Face = x.Face
                    }
                ).ToList();

            for (int i = 0; i < groupCards.Count() - 1; i++)
            {
                if ((groupCards[i].Face + 1) != groupCards[i + 1].Face)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            var groups = hand.Cards.GroupBy(x => x.Face);

            return groups.Count() == 3 && groups.Any(x => x.Count() == 3);
        }

        public bool IsTwoPair(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            return hand
                    .Cards
                    .GroupBy(x => x.Face)
                    .Count(x => x.Count() == 2) == 2;
        }

        public bool IsOnePair(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }
           
            return hand.Cards.GroupBy(x => x.Face).Count() == 4;
        }

        public bool IsHighCard(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            if (this.IsFlush(hand))
            {
                return false;
            }

            return hand.Cards.GroupBy(x => x.Face).Count() == 5;
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
