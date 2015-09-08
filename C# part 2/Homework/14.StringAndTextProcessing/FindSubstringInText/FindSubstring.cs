using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FindSubstringInText
{
    class FindSubstring
    {
        static void Main()
        {
            string input = @"We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

            string regex = @"(?i)in";

            MatchCollection matches = Regex.Matches(input, regex);
            int counter = 0;
            foreach (var match in matches)
            {
                counter++;
            }
            Console.WriteLine(counter);

            //string regex = "in";
            //Console.WriteLine(Regex.Matches(input, regex, RegexOptions.IgnoreCase).Count);
        }
    }
}
