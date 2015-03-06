namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    public class AdjustableChair : Chair, IAdjustableChair
    {
        public AdjustableChair(string modelInitial, MaterialType materialInitial, decimal priceInitial, decimal heightInitial, int numberOfLegsInitial)
            : base(modelInitial, materialInitial, priceInitial, heightInitial, numberOfLegsInitial)
        {            
        }
        public void SetHeight(decimal height)
        {
            base.Height = height;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
