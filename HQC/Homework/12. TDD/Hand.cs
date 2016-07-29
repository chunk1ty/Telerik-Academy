using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            if (cards == null)
            {
                throw new ArgumentNullException();
            }

            foreach (var item in cards)
            {
                if (item == null)
                {
                    throw new ArgumentNullException("Card cannot be null");
                }
            }

            this.Cards = cards;
        }

        public override string ToString()
        {
            if (this.Cards.Count == 0)
            {
                return "The hand is empty";
            }

            return string.Join(" | ", this.Cards);
        }
    }
}
