using System;

class PrintTriangelC
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int row = 1; row <= n; row++)
        {
            for (int column = 1; column <= n; column++)
            {
                if (row == column)
                { 
                        Console.Write("X ");
                }
                else 
                {
                    Console.Write("{0} ",column);
                }
            }  
            Console.WriteLine();
        }
    }
}

