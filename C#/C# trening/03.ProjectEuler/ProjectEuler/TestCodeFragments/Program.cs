using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodeFragments
{
    class Program
    {
        static void Main(string[] args)
        {
            const int number = 1000000;

            long maxCounter = 0;
            long numberProducesLongestChain = 0;
            long nextNumber = 0;

            for (int i = 2; i <= number; i++)
            {
                int count = 1;
                nextNumber = i;
                while (nextNumber != 1)
                {
                    if ((nextNumber % 2) == 0)
                    {
                        nextNumber = nextNumber / 2;
                    }
                    else
                    {
                        nextNumber = nextNumber * 3 + 1;
                    }
                    count++;
                }

                //Check if sequence is the best solution
                if (count > maxCounter)
                {
                    maxCounter = count;
                    numberProducesLongestChain = i;
                }
            }

            Console.WriteLine(numberProducesLongestChain);
        }
    }
}
