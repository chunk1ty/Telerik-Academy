// Draw BGR flag

using System;

class FirstProgram
{
    static void Main()
    {
        int size;
        do
        {
        Console.Write("Flag size ");
        size = int.Parse(Console.ReadLine());
        } while (size < 5 || size % 2 == 0);

        int center = size / 2 ;

        for (int row = 0; row < center; row++)
        {
            for (int ch = 0; ch < size; ch++)
            {
                if (ch==row)
                {
                    Console.Write('\\');
                }
                else if ( ch==center )
                {
                    Console.Write('|');
                }
                else if (ch == size - row - 1)
                {
                    Console.Write('/');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }
        Console.Write(new string('-',center));
        Console.Write('*');
        Console.Write(new string('-', center));
        Console.WriteLine();

        for (int row = 0; row < center; row++)
        {
            for (int ch = 0; ch < size; ch++)
            {
                if (ch == center - row-1)
                {
                    Console.Write('/');
                }
                else if (ch == center)
                {
                    Console.Write('|');
                }
                else if (ch == center+row+1)
                {
                    Console.Write('\\');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }
    }
}

