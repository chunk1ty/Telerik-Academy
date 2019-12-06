using System;

namespace FactoryMethod.Products
{
    /// <summary>
    /// Concrete products provide various implementations of the product interface.
    /// </summary>
    public class XiaomiMi : Gsm
    {
        public XiaomiMi()
        {
            Name = "XiaomiMi";
        }

        public override void Start()
        {
            Console.WriteLine("Starting XiaomiMi...");
        }
    }
}
