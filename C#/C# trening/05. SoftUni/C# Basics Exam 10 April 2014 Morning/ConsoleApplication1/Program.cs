namespace ConsoleApplication1
{
    using System;
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int doubleSize = size * 2;
            int fullLenght = doubleSize * 2 + size;
            int center = size / 2;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < fullLenght; col++)
                {
                    
                    if (col < doubleSize)
                    {
                        if (row == 0 || col == 0 || row == size - 1 || col == doubleSize - 1)
                        {
                            Console.Write("*");   
                        }                        
                        else
                        {
                            Console.Write("/");
                        }
                        
                    }
                    else if (doubleSize + size < col+1)
                    {
                        if (row == 0 || col == doubleSize + size || row == size - 1 || col == fullLenght - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("/");
                        }
                        
                    }
                    else
                    {
                        if (row == center )
                        {
                            Console.Write("|");
                        }
                        else
                        {
                            Console.Write(" ");
                        }                        
                    }                    
                }
                Console.WriteLine();
            }
        }
    }
}
