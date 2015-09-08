namespace DayOfWeekConsoleClient
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            var client = new ServiceReferenceDayOfWeek.DayOfWeekClient();            

            Console.WriteLine(client.GetDayOfWeek(new DateTime(1988, 11, 14)));

            client.Close();
        }
    }
}
