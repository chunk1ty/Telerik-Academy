using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOfMaximum20Char
{
    class Max20Char
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder(input);

            if (input.Length > 20)
            {
                throw new ArgumentOutOfRangeException();                
            }

            for (int i = input.Length-1; i <=20; i++)
            {
                sb.Append('*');
            }
             
            Console.WriteLine(sb);
        }
    }
}
