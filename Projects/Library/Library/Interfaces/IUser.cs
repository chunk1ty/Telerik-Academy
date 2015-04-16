namespace Library
{
    using System;
    using System.Collections.Generic;

    public interface IUser : IProfile
    {
        ICollection<IReadable> ReadItems { get; }

        ICollection<IReadable> CurrentlyReadItems { get; }

        ICollection<IReadable> WishedToReadItems { get; }

        void AddToCurrentReadable(IReadable readable);

        void AddToWishedReadable(IReadable readable);

        void RemoveCurrentReadable(IReadable readable);

        void RemoveWishedReadable(IReadable readable);

        void FinishReadable(IReadable readable);
    }
}
