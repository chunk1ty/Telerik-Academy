namespace Library
{
    using System;

    public class LibraryCommonException : ApplicationException
    {
        public const string ExceptionMessageForKeywordsLength = "Keyword cannot be less than 3 symbols!";
        public const string ExceptionMessageForRatingPoints = "Rating points must be between 1 and 5!";
        public const string WrongUsernameExceptionMessage = "Wrong username, please enter your username!";
        public const string WrongPasswordExceptionMessage = "Wrong pasword, please enter again your password!"; 
        public const string PofileTypeExceptionMessage = "You must specify a profile type!";
        public const string ReadableTypeExceptionMessage = "You must specify what kind of readable item you want to create!";        

        public LibraryCommonException(string message)
            : base(message)
        {
        }        
    }
}
