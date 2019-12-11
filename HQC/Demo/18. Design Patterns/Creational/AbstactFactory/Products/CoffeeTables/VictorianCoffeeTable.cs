namespace AbstractFactory.Products.CoffeeTables
{
    /// <summary>
    /// Concrete Products are various implementations of abstract products, grouped by variants.
    /// </summary>
    public class VictorianCoffeeTable : ICoffeeTable
    {
        public string Name => "Victorian Coffee table";
    }
}