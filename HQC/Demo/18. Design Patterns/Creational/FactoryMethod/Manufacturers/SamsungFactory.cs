using FactoryMethod.Products;

namespace FactoryMethod.Manufacturers
{
    /// <summary>
    /// Concrete creators override the factory method to change the resulting product's type.
    /// </summary>
    public class SamsungFactory : Manufacturer
    {
        public override Gsm ManufactureGsm()
        {
            return new SamsungGalaxy { BatteryLife = 999, Height = 199, Weight = 99, Width = 49 };
        }
    }
}
