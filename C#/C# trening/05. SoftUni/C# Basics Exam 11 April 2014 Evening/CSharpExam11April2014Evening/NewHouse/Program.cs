namespace NewHouse
{
    using System;
    class Program
    {
        
        static void Main()
        {
            
            int size = int.Parse(Console.ReadLine());
            int center = size / 2;
            int rowLen = size - center;

            for (int row = 0; row < rowLen; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (center > col + row)
                    {
                        Console.Write("-");
                    }
                    else
                    if (col > center + row)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write("*");
                    }                    
                }
                Console.WriteLine();
            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (col == 0 || col == size-1)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
