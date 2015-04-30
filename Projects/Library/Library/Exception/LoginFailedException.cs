namespace Library
{
    using System;

    public class LoginFailedException : ApplicationException
    {
        public const string IncorrectPasswordException = "You have entered incorrect password!";
        public const string InvalidUserException = "User with that name does not exist!";

        public LoginFailedException(string message)
            : base(message)
        {
        }
    }
}
