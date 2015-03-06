using System;

class MostNegativeNumbersInColumn
{
    static void Main()
    {
        //test matrix
        int[,] matrix = 
        {
            {1, 2, 0, 1, 7, 1},
            {7, 8, 2, 5, 0, -1},           // in this case this is second column
            {-7, -2, 0, 3, -9, -4},
            {9, -4, 2, 7, -8, -5}
        };

        NegativeNumberInColumn(matrix);

    }

     static void NegativeNumberInColumn(int[,] matrix)
    {
        int counter = 0;
        int maxCounter = 0;
        int bestCol = 0;

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (matrix[row, col] < 0)
                {
                    counter++;
                }
            }
            if (counter > maxCounter)
            {
                maxCounter = counter;
                bestCol = col;
            }
            counter = 0;
        }

        Console.WriteLine("The number of column with most negative numbers is {0} (Count start from 1)", bestCol + 1);
    }
}

