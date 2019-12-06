using System;

namespace FactoryMethod.Products
{
    /// <summary>
    /// Concrete products provide various implementations of the product interface.
    /// </summary>
    public class SamsungGalaxy : Gsm
    {
        public SamsungGalaxy()
        {
            Name = "SamsungGalaxy";
        }

        public override void Start()
        {
            Console.WriteLine("Starting SamsungGalaxy...");
        }
    }
}
