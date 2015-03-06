using System;

class PrintTriangelB
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();


        for (int row = 1; row <= n; row++)
        {

            for (int column = 1; column <= row; column++)
            {
                Console.Write("{0} ", column);
            }
            for (int column = 1; column <= n-row; column++)
            {
                Console.Write("X ");
            }
            Console.WriteLine();
        }
    }
}

