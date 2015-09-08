using System;

class CalculateNumbersInString
{
    static void Main()
    {
        string inputValues = Console.ReadLine();

        string[] array = inputValues.Split(' ');

        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += int.Parse(array[i]);
        }
        Console.WriteLine(sum);
    }
}

