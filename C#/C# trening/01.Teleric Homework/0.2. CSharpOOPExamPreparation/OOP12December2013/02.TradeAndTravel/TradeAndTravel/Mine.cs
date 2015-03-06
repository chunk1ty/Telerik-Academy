using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeAndTravel
{
    public class Mine : GatheringLocation
    {
        public Mine(string name)
            : base(name, ItemType.Iron, ItemType.Armor, LocationType.Mine)
        {
        }
    }
}
