namespace UserInterface.Interfaces
{
    using System;
    using Library;

    public interface IMagazine : IReadable
    {
        string Issue { get; }
    }
}
