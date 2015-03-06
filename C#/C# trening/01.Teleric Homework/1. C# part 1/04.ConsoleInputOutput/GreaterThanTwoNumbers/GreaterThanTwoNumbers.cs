using System;

class GreaterThanTwoNumbers
{
    static void Main()
    {
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        decimal secondNumber = decimal.Parse(Console.ReadLine());
        decimal greater = Math.Max(firstNumber, secondNumber);
        Console.WriteLine(greater);

        //if (firstNumber > secondNumber)
        //{
        //    Console.WriteLine(firstNumber);
        //}
        //else
        //{
        //    Console.WriteLine(secondNumber);
        //}
    }
}
