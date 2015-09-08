using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        BigInteger firstNumber = BigInteger.Parse(Console.ReadLine());
        BigInteger secondNumber = BigInteger.Parse(Console.ReadLine());
        BigInteger thirdnumber = BigInteger.Parse(Console.ReadLine());
        BigInteger nextNumber = 0;
        int search = int.Parse(Console.ReadLine()); 

        for (int i = 0; i < search-3; i++)
        {
            nextNumber = firstNumber + secondNumber + thirdnumber;
            firstNumber = secondNumber;
            secondNumber = thirdnumber;
            thirdnumber = nextNumber;      
        }
        Console.WriteLine(thirdnumber);
        
    }
}

