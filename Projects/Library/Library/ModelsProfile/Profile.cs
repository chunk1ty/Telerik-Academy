namespace Library
{
    using System;

    public abstract class Profile : IProfile
    {
        private const int MinName = 2;
        private const int MaxName = 15;

        private string name;
        private string password;
        private ProfileType profileType;

        public Profile(string name, string password, ProfileType profileType)
        {
            this.Name = name;
            this.Password = password;
            this.ProfileType = profileType;
        }

        public string Name
        {
            get { return this.name; }
            private set 
            {
                LibraryUserException.CheckIfNameIsNullOrEmpty(value, LibraryUserException.NullNameException);
                LibraryUserException.CheckIfNameLengthIsValid(value, MaxName, MinName, LibraryUserException.NameLengthExceptionMsg);
                this.name = value; 
            }
        }

        public string Password
        {
            set 
            {
                LibraryUserException.CheckPasswordLength(value, LibraryUserException.InvalidPasswordException);
                this.password = value; 
            }
        }

        public ProfileType ProfileType
        {
            get { return this.profileType; }
            private set { this.profileType = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}", this.profileType.ToString().ToLower(), this.name, this.password);
        }
    }
}
