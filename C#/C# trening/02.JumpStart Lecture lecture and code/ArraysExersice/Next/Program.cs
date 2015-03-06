using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Next
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 5, 4, -7, -9 };

            int i = 0;
            while (i<myArray.Length && myArray[i] !=0)
            {
                i++;
            }

            int sum = 0;
            int counter = 0;

            for (int j = 0; j < myArray.Length - 1; j++)
            {
                if (myArray[j]<0)
                {
                    sum += myArray[j];
                    counter++;
                }
            }

            Console.WriteLine("Average: {0} Count {1}", (double)sum / counter, counter);
        }
    }
}
