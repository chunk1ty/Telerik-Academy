using System;

class SandGlass
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int center = size / 2;
        for (int row = 0; row < size/2; row++)
        {
            for (int col = 0; col < size; col++)
            {
                if ((col >= row) && (size - row - 1 >= col))
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

        for (int row = 0; row < 1; row++)
        {
            for (int col = 0; col < size; col++)
            {
                if (col==center)
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

        for (int row = 0; row < size / 2; row++)
        {
            for (int col = 0; col < size; col++)
            {
                if ((center - row - 1 <= col) && (col <= center + row + 1))                               
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

