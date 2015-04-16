namespace Library
{
    using System;

    public interface IReadable
    {
        string Name { get; }

        int Year { get; }

        string Publisher { get; }

        string ToString();
    }
}
