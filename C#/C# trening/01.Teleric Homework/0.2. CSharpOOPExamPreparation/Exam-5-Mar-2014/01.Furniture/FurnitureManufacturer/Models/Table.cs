namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    using System;
    public class Table : Furniture, ITable
    {
        private decimal length;
        private decimal width;

        public Table(string modelInitial, MaterialType materialInitial, decimal priceInitial, decimal heightInitial, decimal lengthInitial, decimal widthInitial)
            : base(modelInitial,materialInitial,priceInitial,heightInitial)
        {
            this.Length = lengthInitial;
            this.Width = widthInitial;
        }
        public decimal Length
        {
            get 
            {
                return this.length;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Table length cannot be less or equal to 0");
                }
                this.length = value;
            }
        }
        public decimal Width
        {
           get 
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Table width cannot be less or equal to 0");
                }
                this.width = value;
            }
        }
        public decimal Area
        {
            get 
            {
                return this.Length * this.Width;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Length: {0}, Width: {1}, Area: {2}", this.Length, this.Width, this.Area);
        }
    }
}
