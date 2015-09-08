using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    class Program
    {
        static void Main()
        {
            string text = "Andriyan Nevelinov Krastev";
           //string regex = @".";                  //return evrithing except new line
           //string regex = @"\s";                  //return ' ', \t, \n,
           //string regex = @"\S";                  //return everything except \s
           //string regex = @".||\s";              //return evrything
           //string regex = @"[a-d]";              //check all string and return match (in this case //d a a)
           //string regex = @"[^a-d]";             //return every thing except match at diapasone a-d.
           //string regex = @"\w";                 //return words, numbers and _ (remove ! @ # $ ..) 
           //string regex = @"\w+";                 //return 3 matches -> Andriyan Nevelinov Krastev
           //string regex = @"\W";                   //return everything except words, numbers and _ (escaping! @ # $ ..)
           //string regex = @"[A/-Z]";             // 3 matches -> A N K
           //string regex = @"\d";                  // d is like DIGIT return every digits [0-9]
           //string regex = @"\D";                  // return everything except digits
            string regex = @"\AAndriyan Nevelinov";

            // * -> zero or more matches         //звездата мачва прекалено много и не се ползва много
            // *? -> zero or more matches, but lowers count
            // + -> one or more matches
            // +? -> one or more matches , but lowers count (най-късия string който отгожваря)
            // ? -> zere or one match
            // {5} -> точно 5 matches
            // {5,} -> поне 5 matches
            // {5,8} -> поне 5 matches и най-много 8 matches
            MatchCollection matches = Regex.Matches(text, regex);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
