namespace Library
{
    using System;

    public interface IReadableItemsFactory
    {
        IReadable CreateReadableItem(string[] data);
    }
}
