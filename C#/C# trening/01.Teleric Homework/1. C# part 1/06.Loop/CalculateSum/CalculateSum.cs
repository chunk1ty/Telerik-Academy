using System;

class CalculateSum
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter X: ");
        int x = int.Parse(Console.ReadLine());
        double sum = 0;
        int factorial = 1;
        int pow;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            pow = (int)Math.Pow(x, i);
            sum = sum + factorial / (double)pow;
        }

        sum++;
        Console.WriteLine(sum);
    }
}

