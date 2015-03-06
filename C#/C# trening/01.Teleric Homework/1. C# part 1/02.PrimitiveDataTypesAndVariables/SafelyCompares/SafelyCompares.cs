using System;

class SafelyCompares
{
    static void Main()
    {
        //decimal firstValue = 5.3M;
        //decimal secondValue = 6.01M;
        //double firstValue = 5.00000000001;
        //double secondValue = 5.00000000003;

        Console.Write("First Value : ");
        double firstValue = double.Parse(Console.ReadLine());
        Console.Write("Second Value : ");
        double secondValue = double.Parse(Console.ReadLine());
        
        double result = Math.Abs (firstValue - secondValue);
        if ( result < 0.000001)
            Console.WriteLine(true);
        else
            Console.WriteLine(false);
    }
}

