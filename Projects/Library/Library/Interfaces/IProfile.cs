namespace Library
{
    using System;

    public interface IProfile
    {
        string Name { get; }

        string Password { set; }

        string ToString();
    }
}
