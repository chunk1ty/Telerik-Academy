using System;

class FindBiggestOfThreeInt
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int biggestNumber;

        if (firstNumber >= secondNumber && firstNumber > thirdNumber)
        {
            biggestNumber = firstNumber;
        }
        else if (secondNumber>firstNumber && secondNumber>thirdNumber)
        {
            biggestNumber = secondNumber; 
        }
        else
        {
            biggestNumber = thirdNumber;
        }
        Console.WriteLine(biggestNumber);
    }
}
