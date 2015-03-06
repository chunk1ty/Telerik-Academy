using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UpCase
{
    class UpLetter
    {
        static void Main()
        {
            string inputText = @"We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            int startIndex = 0;
            int endIndex = 0;

            for (int i = 0; i < inputText.Length -8; i++)
            {
                if (inputText.Substring(i, 8) == "<upcase>")
                {
                    startIndex = i;
                }

                if (inputText.Substring(i, 9) == "</upcase>")
                {
                    endIndex = i;                   

                    int length = endIndex - startIndex ;
                    string result = inputText.Substring(startIndex + 8, length-8).ToUpper();

                    inputText = inputText.Remove(startIndex, length + 9);
                    inputText = inputText.Insert(startIndex, result);
                }
            }
            Console.WriteLine(inputText);
        }
    }
}
