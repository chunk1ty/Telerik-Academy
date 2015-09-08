using System;

class CalculateSum
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int numberN = int.Parse(Console.ReadLine());
        
        decimal positiveSum = 0M;
        decimal negativSum = 0M;

        for (int i = 2; i <= numberN; i++)
        {
            if (i % 2 == 0)
            {
                positiveSum = positiveSum + (1.0M / i);
            }
            else 
            {
                negativSum = negativSum + (- 1.0M / i);
            }
        }
        //Console.WriteLine(positiveSum);
        //Console.WriteLine(negativSum);
        decimal sum = 1 + positiveSum + negativSum;
        Console.WriteLine("{0:0.000}",sum);
        Console.WriteLine("{0:f3}", sum);
    }
}

