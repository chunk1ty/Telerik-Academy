namespace LongestCollatzSequence
{
    using System;

    public class CollatzProblem
    {
        static void Main()
        {
            long counter = 0;
            long maxCounter = 0;
            long numberProducesLongestChain = 0;
            long nextNumber = 0;

            for (int i = 2; i <= 1000000; i++)
            {
                nextNumber = i;
                counter = 1;

                while (nextNumber != 1)
                {
                    if (nextNumber % 2 == 0)
                    {
                        nextNumber = nextNumber / 2;
                    }
                    else
                    {
                        nextNumber = nextNumber * 3 + 1;
                    }

                    counter++;
                }

                if (maxCounter < counter)
                {
                    maxCounter = counter;
                    numberProducesLongestChain = i;
                }
            }
            Console.WriteLine(numberProducesLongestChain);
        }

    }
}
