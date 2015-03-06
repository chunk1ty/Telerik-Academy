using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToDecHexPercentageAndScientific
{
    class NumberOperation
    {
        static void Main()
        {
            int number = 17;

            Console.WriteLine("{0,15:D}",number);
            Console.WriteLine("{0,15:X}", number);
            Console.WriteLine("{0,15:P}", number);
            Console.WriteLine("{0,15:F}", number);
        }
    }
}
