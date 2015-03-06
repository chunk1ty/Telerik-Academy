using System;

class PrintTriangelD
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int row = 1; row <= n; row++)
        {
            for (int column = 1; column <= n; column++)
            {
                Console.Write("{0} ",(column+row-1));      
            }  
            Console.WriteLine();
           
        }
    }
}

