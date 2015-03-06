using System;

class Lines
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

        int line = 0;
        int maxLine = int.MinValue;
        int count = 0;

        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                line = 0;
                while (col < 8 && matrix[row, col] == 1) 
                {
                    line++;
                    col++;
                    if (line==maxLine)
                    {
                        count++;
                    }
                    if (line>maxLine)
                    {
                        maxLine = line;
                        count = 1;
                    }
                }   
            }
        }
  
        for (int col = 0; col < 8; col++)
        {
            for (int row = 0; row < 8; row++)
            {
                line = 0;
                while (row < 8 && matrix[row, col] == 1)
                 {
                    line++;
                    row++;
                    if (line == maxLine)
                    {
                        count++;
                    }
                    if (line > maxLine)
                    {
                        maxLine = line;
                        count = 1;
                    }
                }
            }
        }
        if (maxLine==1)
        {
            count = count / 2;
        }
        Console.WriteLine(maxLine);
        Console.WriteLine(count);
        
    }
}

