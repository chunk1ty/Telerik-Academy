using System;

class PrintMatrix
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int row = 1; row <= number; row++)
        {
            for (int nextRow = 1; nextRow <= number; nextRow++)
            {
                Console.Write("{0,4}",(nextRow+row-1));
            }
            Console.WriteLine();
        }
    }

}