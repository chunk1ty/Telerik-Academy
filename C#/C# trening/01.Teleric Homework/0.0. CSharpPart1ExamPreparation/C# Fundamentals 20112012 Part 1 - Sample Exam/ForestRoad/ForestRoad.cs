using System;

class ForestRoad
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                if (row==col)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }

        for (int row = 0; row < size-1; row++)
        {
            for (int col = 0; col < size; col++)
            {
                if (size-row-2==col)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}

