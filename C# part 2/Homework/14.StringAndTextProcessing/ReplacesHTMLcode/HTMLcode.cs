using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplacesHTMLcode
{
    class HTMLcode
    {
        static void Main()
        {
            string input = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
            string firstRegex = @"<\s*a\s*\bhref\b\s*=\s*""";
            string secondRegex = @"""\s*>";
            string thirdRegex = @"<\s*/a\s*>";

            var replace = Regex.Replace(input, firstRegex, "[URL=");
            replace = Regex.Replace(replace, secondRegex, "]");
            replace = Regex.Replace(replace, thirdRegex, "[/URL]");

            Console.WriteLine(replace);
        }
    }
}
