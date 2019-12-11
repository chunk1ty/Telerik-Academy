namespace AbstractFactory.Products.Chairs
{
    /// <summary>
    /// Abstract Products declare interfaces for a set of distinct but related products which make up a product family.
    /// </summary>
    public interface IChair
    {
        int Legs { get; }
    }
}