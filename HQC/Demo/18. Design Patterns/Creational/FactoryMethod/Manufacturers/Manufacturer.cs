using FactoryMethod.Products;

namespace FactoryMethod.Manufacturers
{
    /// <summary>
    /// The creator class declares the factory method that must return an object of a product class. The creator's subclasses usually provide the implementation of this method.
    /// </summary>
    public abstract class Manufacturer
    {
        /// <summary>
        /// The creator may also provide some default implementation of the factory method.
        /// </summary>
        /// <returns></returns>
        public abstract Gsm ManufactureGsm();
    }
}
