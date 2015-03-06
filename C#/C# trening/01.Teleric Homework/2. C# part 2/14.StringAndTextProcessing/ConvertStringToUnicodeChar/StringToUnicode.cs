using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertStringToUnicodeChar
{
    class StringToUnicode
    {
        static void Main()
        {
            string input = "Hi!";

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write("\\u{0:X4}", (int)input[i]);
                //                   X-> hecadecimal number
                //                     4-> 4 has it display four digits. 
            }
            Console.WriteLine();
        }
    }
}
