using System;

class TwoPositiveNumbersDivisionBy5
{
    static void Main()
    {
        Console.Write("Enter first positive integer number: ");
        uint firstPositiveNumber = uint.Parse(Console.ReadLine());
        Console.Write("Enter second positive integer number: ");
        uint secondPositiveNumber = uint.Parse(Console.ReadLine());
        uint numbersOfthisInterval = 0;

        for (uint i = firstPositiveNumber; i <= secondPositiveNumber; i++)
        {
            if (i % 5 == 0)
            {
                numbersOfthisInterval++;
            }
            
        }
        Console.WriteLine(numbersOfthisInterval);
    }
}

