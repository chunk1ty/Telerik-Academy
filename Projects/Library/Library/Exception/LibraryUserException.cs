namespace Library
{
    using System;

    public class LibraryUserException : ApplicationException
    {
        public const string InvalidPasswordException = "Password must be at least 6 symbols!";
        public const string InvalidUsernameException = "Username must be at least 8 symbols!";
        public const string ExistingUserException = "User already exists in the library!";
        public const string ExistingReadableItemInListMsg = "This item alredy exist in the list!";
        public const string NullNameException = "Name should be enterd!";
        public const string NameLengthExceptionMsg = "Name must be between 2 and 15 symbols long!";

        public LibraryUserException(string message)
            : base(message)
        {
        }

        public static void CheckIfNameIsNullOrEmpty(string text, string message = null)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new NullReferenceException(message);
            }
        }

        public static void CheckIfNameLengthIsValid(string text, int max, int min = 0, string message = null)
        {
            if (text.Length < min || max < text.Length)
            {
                throw new IndexOutOfRangeException(message);
            }
        }

        public static void CheckPasswordLength(string text, string message = null)
        {
            if (text.Length < 6)
            {
                throw new IndexOutOfRangeException(message);
            }
        }
    }
}
