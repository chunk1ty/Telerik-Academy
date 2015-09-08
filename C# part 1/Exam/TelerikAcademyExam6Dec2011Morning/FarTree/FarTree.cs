using System;

class FarTree
{
    static void Main()
    {
        //int size = int.Parse(Console.ReadLine());
        //int center = size -2;

        //for (int row = 0; row < size - 1; row++)
        //{
        //    for (int col = 0; col < size * 2 - 3; col++)
        //    {
        //        if ((col<center-row) || (col-row>center))
        //        {
        //            Console.Write(".");
        //        }
        //        else
        //        {
        //            Console.Write("*");
        //        }
        //    }
        //    Console.WriteLine();
        //}
        //for (int row = 0; row < 1; row++)
        //{
        //    for (int col = 0; col < size * 2 - 3; col++)
        //    {
        //        if (col == center)
        //        {
        //            Console.Write("*");
        //        }
        //        else
        //        {
        //            Console.Write(".");
        //        }
        //    }
        //    Console.WriteLine();
        //}

        //Nakov Solution
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i < n; i++)
        {
            int asterisks = 2 * i - 1;
            int dots = n - i - 1;
            Console.Write(new string ('.',dots));
            Console.Write(new string('*', asterisks));
            Console.Write(new string('.', dots));
            Console.WriteLine();
        }
        Console.Write(new string('.', n - 2));
        Console.Write(new string('*', 1));
        Console.Write(new string('.', n - 2));
        Console.WriteLine();
    }
}
