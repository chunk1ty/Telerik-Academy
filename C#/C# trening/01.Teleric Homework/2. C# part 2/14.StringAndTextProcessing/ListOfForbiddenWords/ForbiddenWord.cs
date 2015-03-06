using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ListOfForbiddenWords
{
    class ForbiddenWord
    {
        static void Main()
        {
            string text = @"Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

            //string regex = @"(\b(Microsoft|PHP|CLR)\b)";
            //Console.WriteLine(Regex.Replace(text, regex, m => new String('*',m.Length)));

            string[] forbidenWords = { "Microsoft", "CLR", " PHP " };
            int length = forbidenWords.Length;

            foreach (var word in forbidenWords)
            {
                string asterisks = new string('*', word.Length);                       
                text = text.Replace(word, asterisks);
            }

            Console.WriteLine(text);
        }
    }
}
