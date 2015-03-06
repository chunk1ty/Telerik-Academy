using System;

class USAFlagDraw
{
    static void Main()
    {
        int rows,colomns;

        do
        {
            Console.Write("Flag size ");
            rows = int.Parse(Console.ReadLine());
        } while (rows < 8 );

        colomns = rows * 2;
        int starsWidth = colomns * 4 / 10;
        int starsHeight = rows * 4 / 10;

        for (int row = 0; row < starsHeight; row++)
        {
            for (int ch = 0; ch < colomns; ch++)
            {
                if (ch<starsWidth)
                {
                    if ( row % 2 ==0)
                    {
                        Console.Write(ch%2==0?'*':' ');
                    }
                    else
                    {
                        Console.Write(ch%2==0?' ':'*');
                    }

                }
                else
                {
                    Console.Write('-');       
                }
            }
            Console.WriteLine();
        }

        for (int row = 0; row < rows-starsHeight; row++)
        {
            Console.WriteLine(new string('-',colomns));
        }
    }
}

