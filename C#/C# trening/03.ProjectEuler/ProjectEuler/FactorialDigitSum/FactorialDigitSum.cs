using System;
using System.Numerics;

class FactorialDigitSum
{
    static void Main()
    {
        BigInteger n = 100;
        BigInteger factorial = 1;

        for (BigInteger i = n; i >= 1; i--)
        {
            factorial *= i;
        }

        BigInteger sumOfDigit = 0;
        while (factorial !=0)
        {
            BigInteger lastDigit = factorial % 10;
            sumOfDigit += lastDigit;
            factorial = factorial / 10;
        }

        Console.WriteLine(sumOfDigit);
    }
}

