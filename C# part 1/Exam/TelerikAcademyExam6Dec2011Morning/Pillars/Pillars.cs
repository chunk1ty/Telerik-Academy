using System;

class Pillars
{
    static void Main()
    {
        int[,] matrix = new int[8, 8];
        for (int row = 0; row < 8; row++)
        {
            int number = int.Parse(Console.ReadLine());
            string numberToString = Convert.ToString(number, 2).PadLeft(8, '0');
            for (int col = 0; col < 8; col++)
            {
                matrix[row, col] = int.Parse(numberToString[col].ToString());
            }
        }


        for (int pillar = 0; pillar <8; pillar++)
        {
            int countLeft = 0;
            int countRight = 0;

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (col>pillar)
                    {
                        countLeft += matrix[row, col];
                    }
                    if (col < pillar)
                    {
                        countRight += matrix[row, col];
                    }
                }
            }
            if (countLeft==countRight)
            {
                Console.WriteLine(7-pillar);
                Console.WriteLine(countRight);
                return;
            }
        }
        Console.WriteLine("No");     
    }
}

