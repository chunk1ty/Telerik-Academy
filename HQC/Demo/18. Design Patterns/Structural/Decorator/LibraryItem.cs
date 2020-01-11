namespace Decorator
{
    /// <summary>
    /// The 'Component' abstract class defines the interface for objects that can have responsibilities added to them dynamically.
    /// </summary>
    internal abstract class LibraryItem
    {
        public int CopiesCount { get; set; }

        public abstract void Display();
    }
}
