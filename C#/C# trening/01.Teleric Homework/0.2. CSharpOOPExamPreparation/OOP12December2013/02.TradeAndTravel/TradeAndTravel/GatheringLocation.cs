using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeAndTravel
{
    public abstract class GatheringLocation : Location, IGatheringLocation
    {
        public ItemType GatheredType { get; protected set; }

        public ItemType RequiredItem { get; protected set; }

        protected GatheringLocation(string name, ItemType gatheredType, ItemType requiredItem, LocationType locationType)
            : base(name, locationType)
        {
            this.GatheredType = gatheredType;
            this.RequiredItem = requiredItem;
        }

        public virtual Item ProduceItem(string name)
        {
            if (this.GatheredType == ItemType.Iron)
            {
                return new Iron(name);
            }
            if (this.GatheredType == ItemType.Wood)
            {
                return new Wood(name);
            }

            return null;
        }
    }
}
