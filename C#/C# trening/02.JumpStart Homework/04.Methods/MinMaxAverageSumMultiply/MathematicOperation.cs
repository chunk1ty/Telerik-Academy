using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxAverageSumMultiply
{
    class MathematicOperation
    {
        static void Main()
        {
            int min = MinValue(-17, 2, 19, -190, 22, 69, 43);
            Console.WriteLine("The min value is {0}",min);

            int max = MaxValue(-17, 2, 19, -190, 22);
            Console.WriteLine("The min value is {0}", max);

            double average = AverageValue(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 17,18);
            Console.WriteLine("Average is {0:f2}",average);

            int sum = CalculateSum (1, 2, 3, 4, 5);
            Console.WriteLine("The sum is {0}", sum);

            long multi = Multiply(4, 5, 3);
            Console.WriteLine("The multiply is {0}",multi);

        }

        static int MinValue (params int[] myArray)
        {
            int min = myArray[0];
            foreach (var element in myArray)
            {
                if (element < min)
                {
                    min = element;
                }
            }
            return min;
        }

        static int MaxValue(params int[] myArray)
        {
            int max = myArray[0];
            foreach (var element in myArray)
            {
                if (element > max)
                {
                    max = element;
                }
            }
            return max;
        }

        static double AverageValue(params int[] myArray)
        {
            double sum = 0;
            foreach (var element in myArray)
            {
                sum += element;
            }
            return sum / myArray.Length;
        }

        static int CalculateSum(params int[] myArray)
        {
            int sum = 0;
            foreach (var element in myArray)
            {
                sum += element;
            }
            return sum;
        }

        static long Multiply(params int[] myArray)
        {
            int sum = 1;
            foreach (var element in myArray)
            {
                sum *= element;
            }
            return sum;
        }
    }
}
