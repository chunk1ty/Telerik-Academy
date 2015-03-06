using System;

class MDiviteN
{
    static void Main()
    {
        Console.Write("N ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("M ");
        int m = int.Parse(Console.ReadLine());

        int counter = 0;

        while (n>=m)
        {
            n = n - m;
            counter++;
        }
        Console.WriteLine("{0} {1}",counter,n);
    }
}

