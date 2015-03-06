using System;

class NandKFacturiel
{
    static void Main()
    {
        Console.WriteLine("Enter N and K (1<N<K): ");
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int factorialN = 1;
        int factorialK = 1;

        if (n > 1 && k > n)
        {
            for (int counter = 1; counter <= n; counter++)
            {
                factorialN = factorialN * counter;

            }

            for (int counter = 1; counter <= k; counter++)
            {
                factorialK = factorialK * counter;

            }

            Console.WriteLine("{0}", ((double)factorialN / factorialK));
        }
        else
        {
            Console.WriteLine("Uncorrect input!");
        }

        // Wrong Program
        //Console.WriteLine("Enter N and K (1<N<K): ");
        //int n = int.Parse(Console.ReadLine());
        //int k = int.Parse(Console.ReadLine());
        //int factorial = 1;
        
        //for (int i = 1; i <= k-n; i++)
        //{
        //    factorial = factorial * i;   
        //}

        //Console.WriteLine(1.0/factorial);
    }
}

