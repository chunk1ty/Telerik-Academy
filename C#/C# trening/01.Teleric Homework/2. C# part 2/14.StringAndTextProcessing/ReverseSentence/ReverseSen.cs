using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReverseSentence
{
    class ReverseSen
    {
        static void Main()
        {
            string input = "C# is not C++, not PHP and not Delphi!";
            char[] separators = { ' ', ',', '!', '?', '.' };
            string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] signs = input.Split(words, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                sb.Append(words[i] + signs[i]);
            }

            Console.WriteLine(sb.ToString());

            //string input = "this is a string";
            //StringBuilder sb = new StringBuilder();

            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    sb.Append(input[i]);
            //}
            //string reverseInput = sb.ToString();

           
        }
    }
}
