namespace UserInterface.Interfaces
{
    using System;
    using Library;

    public interface IBook : IReadable
    {
        string Author { get; } 
    }
}
