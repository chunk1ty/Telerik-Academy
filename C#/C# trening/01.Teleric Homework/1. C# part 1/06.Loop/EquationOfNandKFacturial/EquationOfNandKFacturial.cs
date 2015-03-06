using System;

class EquationOfNandKFacturial
{
    static void Main()
    {
        Console.WriteLine("Enter N and K (1<N<K): ");
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int factorialN = 1;
        int factorialK = 1;
        int factorialKandN = 1;

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

            for (int counter = 1; counter <= k-n; counter++)
            {
                factorialKandN = factorialKandN * counter;

            }

            double resul = (double)(factorialN * factorialK) / factorialKandN;
            Console.WriteLine("Result is {0}", resul);
        }
        else
        {
            Console.WriteLine("Uncorrect input!");
        }
    }
}

