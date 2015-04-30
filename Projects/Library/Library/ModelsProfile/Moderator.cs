namespace Library
{
    using System;

    public class Moderator : User, IModerator
    {
        public Moderator(string name, string password) 
            : base(name, password, ProfileType.Moderator)
        {
        }

        public void RemoveComment()
        {
            throw new NotImplementedException();
        }
    }
}
