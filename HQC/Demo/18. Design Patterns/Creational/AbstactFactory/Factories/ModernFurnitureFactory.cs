using AbstractFactory.Products.Chairs;
using AbstractFactory.Products.CoffeeTables;
using AbstractFactory.Products.Sofas;

namespace AbstractFactory.Factories
{
    /// <summary>
    /// Concrete Factories implement creation methods of the abstract factory. Each concrete factory corresponds to a specific variant of products and creates only those product variants.
    /// </summary>
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new ModernCoffeeTable();
        }
    }
}