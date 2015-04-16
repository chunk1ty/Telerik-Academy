namespace UserInterface.Interfaces
{
    using Library;

    public interface INewspaper : IReadable
    {
        string Issue { get; }
    }
}
