using System;

class FromMtoN
{
    static void Main()
    {
        Console.Write("N ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("M ");
        int m = int.Parse(Console.ReadLine());

        if (m<=n)
        {
            Console.WriteLine("Uncorect input!M must > N");
        }
        else
        {
            for (int i = m-1; i > n; i--)
            {
                Console.WriteLine(i);   
            }
        }
    }
}

