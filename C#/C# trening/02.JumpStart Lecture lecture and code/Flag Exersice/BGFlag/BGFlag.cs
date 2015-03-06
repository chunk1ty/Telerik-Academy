using System;

class BGFlag
{
    static void Main()
    {
        int rows = 9;
        int colomns = 27;

        Console.BackgroundColor = ConsoleColor.White;
        string str = new string(' ', colomns);
        for (int row = 0; row < rows/3; row++)
        {
            Console.WriteLine(str);       
        }

        Console.BackgroundColor = ConsoleColor.Green;
        for (int row = 0; row < rows/3; row++)
        {
            Console.WriteLine(str);
        }

        Console.BackgroundColor = ConsoleColor.Red;
        for (int row = 0; row < rows/3; row++)
        {
            Console.WriteLine(str);
        }
        
    }
}

