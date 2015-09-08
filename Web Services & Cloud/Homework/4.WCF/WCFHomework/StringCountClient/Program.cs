using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCountClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new StringCountService.CountSecondStirngOccurrenceInFirstClient();

            int result = client.CountSecondStirngOccurrenceInFirstt("helllo there you hello man hello!", "hello");

            Console.WriteLine(result);

            client.Close();
        }
    }
}
