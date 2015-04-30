namespace Library
{
    using System;

    public interface IModerator : IUser
    {
        void RemoveComment();
    }
}
