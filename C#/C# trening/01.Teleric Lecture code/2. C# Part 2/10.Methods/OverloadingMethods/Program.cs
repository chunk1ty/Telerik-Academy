using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingMethods
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Multiply("4","5"));
        }

        static int Multiply(int a, int b)
        {
            if (b == 2)
            {
                return a << 1;
            }
            return a * b;
        }

        static int Multiply(string a, string b)
        {
            return Multiply (int.Parse(a),int.Parse(b));
        }

        static int Multiply(int[] numbers)
        {
            int result = 1;

            foreach (var num in numbers)
            {
                result = Multiply(result, num);
            }
            return result;
        }

        static int Multiply(string[] numberAsStrings)
        {
            int[] numbers = new int[numberAsStrings.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(numberAsStrings[i]);
            }
            return Multiply(numbers);
            //int result = 1;
            //foreach (var numStr in numberAsStrings)
            //{
            //    result = Multiply(result, int.Parse(numStr));
            //}
            //return result;
        }
    }
}
