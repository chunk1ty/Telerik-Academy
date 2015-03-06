using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FindWordInSentences
{
    class Program
    {
        static void Main()
        {
            string input = @"We are living in a yellow submarine.";
            

            string regex = @"\bin\b";

            MatchCollection match = Regex.Matches(input, regex);

            if (match.Count > 0)
            {
                Console.WriteLine("ank");
            }
            else
            {
                Console.WriteLine("no");
            }

        }

        
    }
}
