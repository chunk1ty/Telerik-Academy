namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;

    public class ConvertibleChair : Chair, IConvertibleChair
    {
        private decimal nonConvertedHeigth;
        public ConvertibleChair(string modelInitial, MaterialType materialInitial, decimal priceInitial, decimal heightInitial, int numberOfLegsInitial)
            : base(modelInitial, materialInitial, priceInitial, heightInitial, numberOfLegsInitial)
        {
            this.nonConvertedHeigth = heightInitial;
        }

        public bool IsConverted { get; private set; }
        public void Convert()
        {
            if (this.IsConverted)
            {
                this.Height = this.nonConvertedHeigth;
            }
            else
            {
                this.Height = 0.10M;
            }

            this.IsConverted = !this.IsConverted;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", State: {0}", this.IsConverted ? "Converted" : "Normal");
        }
    }
}
