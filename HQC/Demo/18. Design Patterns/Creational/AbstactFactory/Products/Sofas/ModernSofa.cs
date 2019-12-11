using System;

namespace AbstractFactory.Products.Sofas
{
    /// <summary>
    /// Concrete Products are various implementations of abstract products, grouped by variants.
    /// </summary>
    public class ModernSofa : ISofa
    {
        public void SitOn()
        {
            Console.WriteLine("Sitting on Modern Sofa!");
        }
    }
}