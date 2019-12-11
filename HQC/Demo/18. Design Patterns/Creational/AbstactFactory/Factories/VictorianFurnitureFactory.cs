using AbstractFactory.Products.Chairs;
using AbstractFactory.Products.CoffeeTables;
using AbstractFactory.Products.Sofas;

namespace AbstractFactory.Factories
{
    /// <summary>
    /// Concrete Factories implement creation methods of the abstract factory. Each concrete factory corresponds to a specific variant of products and creates only those product variants.
    /// </summary>
    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new VictorianChair();
        }

        public ISofa CreateSofa()
        {
            return new VictorianSofa();
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new VictorianCoffeeTable();
        }
    }
}