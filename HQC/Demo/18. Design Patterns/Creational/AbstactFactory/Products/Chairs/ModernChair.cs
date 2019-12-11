namespace AbstractFactory.Products.Chairs
{
    /// <summary>
    /// Concrete Products are various implementations of abstract products, grouped by variants.
    /// </summary>
    public class ModernChair : IChair
    {
        public int Legs => 1;
    }
}