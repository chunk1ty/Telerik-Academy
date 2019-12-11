namespace AbstractFactory.Products.CoffeeTables
{
    /// <summary>
    /// Abstract Products declare interfaces for a set of distinct but related products which make up a product family.
    /// </summary>
    public interface ICoffeeTable
    {
        string Name { get; }
    }
}