using System;

class EuclideanAlgorithm
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        while (firstNumber != secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                firstNumber = firstNumber - secondNumber;
            }
            else
            {
                secondNumber = secondNumber - firstNumber;
            }
        }
        Console.WriteLine("GCD is " + firstNumber);
    }
}

