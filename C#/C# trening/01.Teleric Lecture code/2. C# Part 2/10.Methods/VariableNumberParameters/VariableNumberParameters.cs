using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableNumberParameters
{
    class VariableNumberParameters
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumNumbers(1,2,3,4,5,6,7,8,9,10));
        }

        static int SumNumbers(params int[] numbers)
        {
            int result = 0;
            foreach (var item in numbers)
            {
                result += item;
            }
            return result;
        }
    }
}
