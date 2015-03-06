using System;

class ChessProblem
{
    static void Main()
    {
        int[,] matrix = new int[8, 8];        

        int p1 = 1;
        int q1 = 3;
        int p2 = 7;
        int q2 = 3;

        matrix[p1, q1] = 1;
        matrix[p2, q2] = 1;

        int minP = Math.Min(p1, p2);
        int minQ = Math.Min(q1, q2);

        int maxP = Math.Max(p1, p2);
        int maxQ = Math.Max(q1, q2);

        int counter = CheckRows(matrix);
        if (counter == 2)
        {
            FillCellsOnRows(matrix, minP, minQ, maxP, maxQ);
            PrintMatrix(matrix);
        }

        counter = CheckColumn(matrix);
        if (counter == 2)
        {
            FilCellsOnColums(matrix, minP, minQ, maxP);
            PrintMatrix(matrix);
        }
        
        
    }

    private static void FilCellsOnColums(int[,] matrix, int minP, int minQ, int maxP)
    {
        for (int col = minQ; col < minQ + 1; col++)
        {
            for (int row = minP + 1; row < maxP; row++)
            {
                matrix[row, col] = 1;
            }
        }
    }

    static int CheckColumn(int[,] matrix)
    {
        int maxCounter = 0;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            int counter = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (matrix[row, col] == 1)
                {
                    counter++;
                }
            }
            if (counter > maxCounter)
            {
                maxCounter = counter;
            }
        }
        return maxCounter;
    }

    static void FillCellsOnRows(int[,] matrix, int minP, int minQ, int maxP, int maxQ)
    {
        for (int row = minP; row <= maxP; row++)
        {
            for (int col = minQ + 1; col < maxQ; col++)
            {
                matrix[row, col] = 1;
            }
        }
    }

    static int CheckRows(int[,] matrix)
    {
        int maxCounter = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int counter = 0;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] == 1)
                {
                    counter++;
                }
            }
            if (counter > maxCounter)
            {
                maxCounter = counter;
            }
        }
        return maxCounter;
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

