using System;

class MaxSumInMatrix
{
    static void EnterMatrix(int[,] myMatrix, int myRow, int myCol)
    {
        for (int row = 0; row < myRow; row++)
        {
            string[] separators = {" ", "\t"};
            string currentRow = Console.ReadLine();
            string[] numbersAsString = currentRow.Split(separators,StringSplitOptions.RemoveEmptyEntries);
            for (int col = 0; col < numbersAsString.Length; col++)
            {
                if (col<myCol)
                {
                    myMatrix[row, col] = int.Parse(numbersAsString[col]);
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("You entered this matrix:");
        PrintMatrix(myMatrix);
    }

    static void PrintMatrix(int[,] myMatrix)
    {
        for (int row = 0; row < myMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < myMatrix.GetLength(1); col++)
            {
                Console.Write("{0, -4} ", myMatrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    static void FindMaxPlatform(int[,] myMatrix)
    {
        int sum = 0;
        int startRow = 0;
        int startCol = 0;
        int maxSum = int.MinValue;

        for (int row = 0; row < myMatrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < myMatrix.GetLength(1) - 2; col++)
            {

                for (int bestR = row; bestR <= row + 2; bestR++)
                {
                    for (int bestC = col; bestC <= col + 2; bestC++)
                    {
                        sum += myMatrix[bestR, bestC];
                    }
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                    startRow = row;
                    startCol = col;
                }
            }
        }
        PrintMaxPlatform(myMatrix, startRow, startCol);
    }

    static void PrintMaxPlatform(int[,] myMatrix, int row, int col)
    {
        for (int i = row; i <= row + 2; i++)
        {
            for (int j = col; j <= col + 2; j++)
            {
                Console.Write("{0,-4} ", myMatrix[i, j]);
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int[,] matrix =
        {
            {1, 9, 2, 4, 5, 6},
            {2, 10, 1, 101, 300, 7},
            {3, 13, 92, 150, 250, 9},
            {4, 17, 83, 160, 190, 10},
            {7, 81, 82, 170, 8, 11},
        };
        //int row = int.Parse(Console.ReadLine());
        //int col = int.Parse(Console.ReadLine());
        //int[,] matrix = new int[row, col];
        //EnterMatrix(matrix, row, col);
        FindMaxPlatform(matrix);

       
    }
}

