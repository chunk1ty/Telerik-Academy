using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = { 3, 4, 5, 6, 7, 9 };
            int[] secondArray = {1,2,3,4,5,6,8 };
            int[] thirdArray = { 4, 6, 9, 10 };

            int firstA = 0;
            int secondA = 0;
            int thirdA = 0;

            while (true)
            {
                int max = Math.Max(firstArray[firstA],Math.Max(secondArray[secondA],thirdArray[thirdA]));

                while (firstA<firstArray.Length && firstArray[firstA]<max)
                {
                    firstA++;
                }
                if (secondA >= secondArray.Length)
                {
                    break;
                }

                while (thirdA < thirdArray.Length && thirdArray[thirdA] < max)
                {
                    thirdA++;
                }
                if (thirdA >= thirdArray.Length)
                {
                    break;
                }

                if (firstArray[firstA] == secondArray[secondA] && secondArray[secondA] == thirdArray[thirdA])
                {
                    Console.WriteLine("{0} {1} {2}",firstA,secondA,thirdA);
                    firstA++;
                    secondA++;
                    thirdA++;

                    if (firstA >= firstArray.Length || secondA >= secondArray.Length || thirdA >= thirdArray.Length)
                    {
                        
                    }
                }

            }
        }
    }
}
