using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;

namespace ReadFullPath
{
    class FilePath
    {
        static void Main()
        {
            string input = Console.ReadLine();
            try
            {                
                string text = File.ReadAllText(input, Encoding.UTF8);
                Console.WriteLine(text);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The file path contains a directory that cannot be found!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file '{0}' was not found!", input);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No file path is given!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The entered file path is not correct!");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The entered file path is too long - 248 characters are the maximum!");
            }
            catch (UnauthorizedAccessException uoae)
            {
                Console.WriteLine(uoae.Message);
            }
            catch (SecurityException)
            {
                Console.WriteLine("You don't have the required permission to access this file!");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Invalid file path format!");
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
            
        }
    }
}
