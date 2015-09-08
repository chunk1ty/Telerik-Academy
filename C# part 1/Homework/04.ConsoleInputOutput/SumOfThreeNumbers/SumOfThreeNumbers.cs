using System;

class SumOfThreeNumbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("The result is : "+(firstNumber+secondNumber+thirdNumber));
    
    }
}

