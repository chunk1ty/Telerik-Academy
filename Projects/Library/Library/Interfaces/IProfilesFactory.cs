namespace Library
{
    using System;

    public interface IProfilesFactory
    {
        IProfile CreateProfile(string[] data);
    }
}
