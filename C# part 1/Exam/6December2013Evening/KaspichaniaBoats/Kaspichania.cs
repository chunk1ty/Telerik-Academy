using System;

namespace KaspichaniaBoats
{
    class Kaspichania
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int center = size ;
            int add = size / 2;
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < 2*size+1; col++)
                {
                    if (row == center - col || col == center || center + row == col)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }                    
                }
                Console.WriteLine();
            }

            for (int row = 0; row < 2*size+1; row++)
            {
                Console.Write('*');
            }
            Console.WriteLine();

            for (int row = 0; row < add+1; row++)
            {
                for (int col = 0; col < 2*size+1; col++)
                {
                    if (row + 1 == col || center == col || 2*size - col == row +1)
                    {                       
                         Console.Write('*');                                              
                    }
                    else
                    {
                        if (col > add && row == add && 2 * size - col > add)
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write('.');
                        }
                        
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}

