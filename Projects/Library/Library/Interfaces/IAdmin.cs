namespace Library
{
    using System;

    public interface IAdmin : IProfile
    {
        void SendToLibrary(string[] data);
        void RemoveFromLibrary(IReadable readable);
    }
}
