using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractsDates
{
    class Dates
    {
        static void Main()
        {
            string input = "some text here blalbal exe ABBA exe andrian_29@abv.bg hahahahaha ank_17@ass.bg 17.13.1992     35.35.9999        12.31.1000  31.12.2013 01.01.2013";

            string regex = @"[0-9]{2}.[0-9]{2}.[0-9]{4}";           

            var matches = Regex.Matches(input, regex);
            DateTime dateValue;

            foreach (Match match in matches)
            {
                string dateString = match.Value.ToString();

                if (DateTime.TryParse(dateString, out dateValue))
                {
                    Console.WriteLine(dateValue.ToString(CultureInfo.GetCultureInfo("en-CA")));                    
                }            
            }
        }
    }
}
