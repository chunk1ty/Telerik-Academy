using System;
using System.Numerics;

class ZerosOfNFactorial
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;
        BigInteger digit;
        int counter = 0;               //12499

        for (int i = 1; i <= number; i++)
        {
            factorial = factorial * i;
        }

        Console.WriteLine(factorial);

        while (true)
        {
            digit = factorial % 10;
            if (digit == 0)
            {
                counter++;
            }
            if (digit != 0)
            {
                break;
            }
            factorial = factorial / 10;
        }

        Console.WriteLine(counter);
    }
}

