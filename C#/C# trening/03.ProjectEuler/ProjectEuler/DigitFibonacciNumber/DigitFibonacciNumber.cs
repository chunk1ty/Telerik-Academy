using System;
using System.Numerics;

class DigitFibonacciNumber
{
    static void Main()
    {
        BigInteger firstValue = 1;
        BigInteger secondValue = 1;

        for (BigInteger i = 3; i < 10000000000000000000; i++)
        {
            BigInteger thirdValue = firstValue + secondValue;

            firstValue = secondValue;
            secondValue = thirdValue;

            string value = secondValue.ToString();
            if (value.Length == 1000)
            {
                Console.WriteLine(i);
                break;
            }
        }

        
        
    }
}

