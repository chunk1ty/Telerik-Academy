namespace Library
{
    static class Login
    {        
        static string username;
        static string password;

        static string Password
        {
            set
            {
                if (value != FileManager.GetUserPassword(username))
                {
                    throw new LibraryCommonException(LibraryCommonException.WrongPasswordExceptionMessage);
                }

                password = value;
            }
        }

        static string Username
        {
            set
            {
                username = value;
            }
        }

        public static void Init(string username, string password)
        {

            if (!FileManager.UserExist(username))
            {
                throw new LibraryCommonException(LibraryCommonException.WrongUsernameExceptionMessage);
            }

            Username = username;
            Password = password;
        }
    }
}
