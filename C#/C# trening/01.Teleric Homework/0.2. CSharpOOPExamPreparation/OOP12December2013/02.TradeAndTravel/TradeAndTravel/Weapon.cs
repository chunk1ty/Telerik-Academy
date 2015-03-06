using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeAndTravel
{
    public class Weapon : Item
    {
        public const int GeneralWeaponValue = 10;
        public int Sharpness { get; protected set; } 

        public Weapon(string name, Location location = null)
            : base(name, Weapon.GeneralWeaponValue, ItemType.Weapon, location)
        {
            this.Sharpness = this.Value;
        }

        public override void UpdateWithInteraction(string interaction)
        {
            base.UpdateWithInteraction(interaction);

            if (interaction == "travel")
            {
                this.Sharpness--;
                if (this.Sharpness < 0)
                {
                    this.Sharpness = 0;
                }
            }
        }

        static List<ItemType> GetComposingItems()
        {
            return new List<ItemType>() { ItemType.Iron, ItemType.Wood };
        }
    }
}
