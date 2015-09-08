using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CheckForEmailAddress
{
    class EmailAddress
    {
        static void Main()
        {
            //not absolutely working correct
            string input = "some text here blalbal exe ABBA exe andrian_29@abv.bg hahahahaha ank_17@ass.bg.com.";
            string regex = @"[\w.]{2,20}@[\w]{2,20}[.]{1}[\w.]{2,6}";

            var matches = Regex.Matches(input, regex);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
