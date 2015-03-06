using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemInSortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 5, 4, 7, 9 };

            for (int i = 0; i < myArray.Length - 1; i++)
            {
                if (myArray[i]>myArray[i+1])
                {
                    Console.WriteLine(myArray[i+1]);
                    break;
                }
            }
        }
    }
}
