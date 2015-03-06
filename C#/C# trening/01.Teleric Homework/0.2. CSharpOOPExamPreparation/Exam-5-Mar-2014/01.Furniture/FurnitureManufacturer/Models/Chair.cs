namespace FurnitureManufacturer.Models
{
    using System;
    using FurnitureManufacturer.Interfaces;

    public class Chair : Furniture, IChair
    {
        private int numberOfLegs;
        public Chair(string modelInitial, MaterialType materialInitial, decimal priceInitial, decimal heightInitial, int numberOfLegsInitial)
            : base(modelInitial, materialInitial, priceInitial, heightInitial)
        {
            this.NumberOfLegs = numberOfLegsInitial;
        }
        public int NumberOfLegs
        {
            get 
            {
                return this.numberOfLegs;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Chair must have more than 3 legs");
                }
                this.numberOfLegs = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("Legs: {0}", this.NumberOfLegs);
        }
    }
}
