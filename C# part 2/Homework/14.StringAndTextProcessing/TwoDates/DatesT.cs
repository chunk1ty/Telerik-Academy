using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDates
{
    class DatesT
    {
        static void Main()
        {
            DateTime firstDate = new DateTime();
            DateTime secondDate = new DateTime();  
          
            firstDate = EnterDate();
            secondDate = EnterDate();
           
            Console.WriteLine("Distance {0} days", (secondDate - firstDate).Days);

        }

        static DateTime EnterDate()
        {
            Console.Write("Enter date: ");
            string input = Console.ReadLine();
            DateTime date = DateTime.ParseExact(input,"d.MM.yyyy",CultureInfo.InvariantCulture);
            return date;
        }

        
    }
}
