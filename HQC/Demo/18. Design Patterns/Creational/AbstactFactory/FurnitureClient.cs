using AbstractFactory.Factories;
using AbstractFactory.Products.Chairs;
using AbstractFactory.Products.CoffeeTables;
using AbstractFactory.Products.Sofas;

namespace AbstractFactory
{
    /// <summary>
    /// Although concrete factories instantiate concrete products, signatures of their creation methods must return corresponding abstract products. This way the client code that uses a factory doesn’t get coupled to the specific variant of the product it gets from a factory. The Client can work with any concrete factory/product variant, as long as it communicates with their objects via abstract interfaces.
    /// </summary>
    public class FurnitureClient
    {
        private readonly IFurnitureFactory _furnitureFactory;

        public FurnitureClient(IFurnitureFactory furnitureFactory)
        {
            _furnitureFactory = furnitureFactory;
        }

        public IChair CreateChair()
        {
            return _furnitureFactory.CreateChair();
        }

        public ISofa CreateSofa()
        {
            return _furnitureFactory.CreateSofa();
        }

        public ICoffeeTable CreteCoffeeTable()
        {
            return _furnitureFactory.CreateCoffeeTable();
        }
    }
}