using System;

class Trapezoid
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        string dots = new string('.', size );
        string asd = new string('*', size );
        Console.WriteLine(dots+asd);

        //center==size
        for (int row = 1; row < size; row++)
        {
            for (int col = 0; col < size*2; col++)
            {
                if ((col == size - row )||(col==2*size-1))
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

        for (int i = 0; i < 2*size; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

