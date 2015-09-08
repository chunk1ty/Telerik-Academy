using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaspichanNumbers
{
    class Kaspichan
    {
        static void Main()
        {
            ulong input = ulong.Parse(Console.ReadLine());
            
            string[] myArray = new string[256];
            NumbersSystem(myArray);

            if (input == 0)
            {
                Console.WriteLine("A");
            }
            string res = string.Empty;

            while (input != 0)
            {
                ulong position = input % 256;
                res = myArray[position] + res;
                input = input / 256;
            }
            Console.WriteLine(res);

        }

        private static void NumbersSystem(string[] myArray)
        {
            for (int i = 0; i < 26; i++)
            {
                myArray[i] = ((char)(i + 'A')).ToString();
            }
            for (int i = 26; i < 256; i++)
            {
                char modulo = (char)((i % 26) + 'A');
                char remainder = (char)((i / 26) + 'a' - 1);
                myArray[i] = (remainder).ToString() + (modulo).ToString();
            }
        }
    }
}


