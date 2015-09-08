using System;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter n (n>=0): ");
        int n = int.Parse(Console.ReadLine());
        if (n<0)
        {
            Console.WriteLine("Uncorrect input!");
        }
        else
        {
            int factorialUp = 1;
            int factorialDown = 1;
            int factorialNormal = 1;
            double expresion;

            for (int i = 1; i <= n*2; i++)
            {
                factorialUp = factorialUp * i;
            }

            for (int i = 1; i <= n+1; i++)
            {
                factorialDown = factorialDown * i; 
            }

            for (int i = 1; i <= n; i++)
            {
                factorialNormal = factorialNormal * i;
            }

            expresion = (double)factorialUp / (factorialDown * factorialNormal);
            Console.WriteLine(expresion);
        }
    
    }
}

