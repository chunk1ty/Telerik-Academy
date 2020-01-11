namespace Decorator
{
    /// <summary>
    /// The 'Decorator' abstract class - maintains a reference to a Component object and defines an interface that conforms to Component's interface.
    /// </summary>
    internal abstract class Decorator : LibraryItem
    {
        protected Decorator(LibraryItem libraryItem)
        {
            LibraryItem = libraryItem;
        }

        protected LibraryItem LibraryItem { get; private set; }

        public override void Display()
        {
            LibraryItem.Display();
        }
    }
}
