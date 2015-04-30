namespace Library
{
    using System;

    public class LibraryItemException : ApplicationException
    {
        public const string ExistingItemException = "This item already exists in the library!";
        public const string NotExistingItemException = "This item does not exist in the library!";
        public const string InvalidGenreException = "This genre does not exist in the library!";
        public const string InvalidKeywordException = "Keyword cannot be less than 3 symbols";            

        public LibraryItemException(string message)
            : base(message)
        {
        }
    }
}
