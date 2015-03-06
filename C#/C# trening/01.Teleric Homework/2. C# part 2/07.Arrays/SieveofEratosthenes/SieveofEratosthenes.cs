using System;

class SieveofEratosthenes
{
    static void Main()
    {
        int size = 10000000;
        bool[] numbers = new bool[size];

        int sizeSqrt = (int)Math.Sqrt(size);

        for (int i = 2; i <= sizeSqrt; i++)
        {
            if (numbers[i] == false)
            {
                for (int j = i * i; j < numbers.Length; j+=i)
                {
                    numbers[j] = true;
                }
            }
        }

        for (int i = 2; i < numbers.Length; i++)
        {
            if (numbers[i] == false)
            {
                Console.WriteLine("{0}",i);
            }
        }
    }
    
}

