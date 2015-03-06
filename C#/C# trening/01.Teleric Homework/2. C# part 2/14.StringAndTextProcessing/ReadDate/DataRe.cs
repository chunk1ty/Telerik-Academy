using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadDate
{
    class DataRe
    {
        static void Main()
        {
            string input = "12.03.2014 16:20:10";

            DateTime date = DateTime.ParseExact(input, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            date = date.AddHours(6);
            date = date.AddMinutes(30);

            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
            Console.WriteLine("{0} {1}",date.ToString("dddd"),date);
            
        }
    }
}
