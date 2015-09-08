using System;

class Fibonacci
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int firstNumber = 0;
        int secondNumber = 1;
        int nextNumber;
        int sum = 1;

        for (int i = 0; i <n-2; i++)
        {
            nextNumber = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = nextNumber;
            sum += nextNumber;
        }
        Console.WriteLine(sum);
    }
}

