namespace Library
{
    using System;
    using System.Collections.Generic;

    public class ProfilesFactory : IProfilesFactory
    {
        public IProfile CreateProfile(string[] data)
        {
            string profileType = data[0];
            string name = data[1];
            string password = data[2];

            switch (profileType)
            {
                case "administrator":
                    return new Admin(name, password);
                case "moderator":
                    return new Moderator(name, password);
                case "regularuser":
                    return new RegularUser(name, password);
                default:
                    throw new LibraryCommonException(LibraryCommonException.PofileTypeExceptionMessage);
            }
        }
    }
}
