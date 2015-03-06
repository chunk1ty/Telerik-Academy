using System;

class GetMax
{
    static void Main()
    {
        int firstValue = ReadIntegerNumber();
        int secondValue = ReadIntegerNumber();
        int thirdValue = ReadIntegerNumber();

        int max = GetBiggestNumber(firstValue,secondValue);
        int biggestNumber = GetBiggestNumber(max, thirdValue);

        Console.WriteLine(biggestNumber);
    }

    static int ReadIntegerNumber()
    {
        Console.Write("Enter a integer number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int GetBiggestNumber(int firstNumber,int secondNumber)
    {
        int max = firstNumber;
        if (secondNumber > firstNumber)
        {
            max = secondNumber;
        }
        return max;
    }
}

