using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            float ank = float.Parse("1.70", CultureInfo.InvariantCulture);

            Console.WriteLine(ank);
        }
    }
}
