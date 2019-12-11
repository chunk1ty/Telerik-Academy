using AbstractFactory.Products.Chairs;
using AbstractFactory.Products.CoffeeTables;
using AbstractFactory.Products.Sofas;

namespace AbstractFactory.Factories
{
    /// <summary>
    /// The Abstract Factory interface declares a set of methods for creating each of the abstract products.
    /// </summary>
    public interface IFurnitureFactory
    {
        IChair CreateChair();

        ISofa CreateSofa();

        ICoffeeTable CreateCoffeeTable();
    }
}