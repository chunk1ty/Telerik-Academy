using System;

class ChechForPrimeNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int devisors = 0;

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
                devisors++;
        }

        if (devisors == 2)
            Console.WriteLine("prime");
        else
            Console.WriteLine("not prime");
    }
}

