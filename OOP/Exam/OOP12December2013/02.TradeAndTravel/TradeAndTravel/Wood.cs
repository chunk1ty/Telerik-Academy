using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeAndTravel
{
    public class Wood : Item
    {
        public const int GeneralWoodValue = 2;

        public Wood(string name, Location location = null)
            : base(name, Wood.GeneralWoodValue, ItemType.Wood, location)
        {
        }

        public override void UpdateWithInteraction(string interaction)
        {
            base.UpdateWithInteraction(interaction);

            if (interaction == "drop")
            {
                this.Value--;
                if (this.Value < 0)
                {
                    this.Value = 0;
                }
            }
        }
    }
}
