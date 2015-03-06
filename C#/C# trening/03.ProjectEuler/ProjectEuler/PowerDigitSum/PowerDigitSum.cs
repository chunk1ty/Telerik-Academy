using System;
using System.Numerics;

class PowerDigitSum
{
    static void Main()
    {
        BigInteger digit = (BigInteger)Math.Pow(2, 1000);

        BigInteger sum = 0;
        while (digit != 0) 
        {
            BigInteger lastDigit = digit % 10;
            sum += lastDigit;
            digit = digit / 10;
        }

        Console.WriteLine(sum);
    }
}

