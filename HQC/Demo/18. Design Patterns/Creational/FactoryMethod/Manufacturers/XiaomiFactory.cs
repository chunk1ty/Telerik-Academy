using FactoryMethod.Products;

namespace FactoryMethod.Manufacturers
{
    /// <summary>
    /// Concrete creators override the factory method to change the resulting product's type.
    /// </summary>
    public class XiaomiFactory : Manufacturer
    {
        public override Gsm ManufactureGsm()
        {
            return new XiaomiMi { BatteryLife = 1000, Height = 200, Weight = 100, Width = 50 };
        }
    }
}
