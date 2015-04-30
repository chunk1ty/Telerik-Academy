using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Library
{
    sealed class FileManager
    {
        public static Uri DatabasePath = new Uri(@"../Library/Database", UriKind.RelativeOrAbsolute);
        public static Uri UsersPath = new Uri(string.Format(@"../../{0}\Users", DatabasePath), UriKind.RelativeOrAbsolute);
        public static Uri BooksPath = new Uri(string.Format(@"../../{0}\Books", DatabasePath), UriKind.RelativeOrAbsolute);

        public FileManager()
        {

        }

        public static bool UserExist(string username)
        {
            if (File.Exists(string.Format(@"{0}\{1}.txt", UsersPath, username)))
            {
                return true;
            }
            return false;
        }

        public static string GetUserPassword(string username)
        {
            using (var sr = new StreamReader(string.Format(@"{0}\{1}.txt", UsersPath, username)))
            {
                return sr.ReadLine();
            }
        }

        public static void CreateUserFile(string username, string password)
        {
            using (var sw = new StreamWriter(string.Format(@"{0}\{1}.txt", UsersPath, username)))
            {
                sw.WriteLine(password);
            }
        }
    }
}
