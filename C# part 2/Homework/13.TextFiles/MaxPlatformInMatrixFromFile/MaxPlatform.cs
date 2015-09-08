using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MaxPlatformInMatrixFromFile
{
    class MaxPlatform
    {
        static void Main()
        {
            StreamReader readMatrix = new StreamReader("../../matrix.txt");
            string currentRow = readMatrix.ReadLine();
            int size = int.Parse(currentRow);

            int[,] matrix = new int[size, size];

            matrix = FillCellsMatrixFromOutputFile(readMatrix, currentRow, matrix);           
            WriteMaxSumAtFile(MaxPlatformInMatrix(matrix));
            
        }

        static void WriteMaxSumAtFile(int maxSum)
        {
            StreamWriter write = new StreamWriter("../../sum.txt");
            using (write)
            {
                write.WriteLine(maxSum);
            }
        }

        static int MaxPlatformInMatrix(int[,] matrix)
        {
            int bestSum = int.MinValue;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                    }
                }
            }
            return bestSum;
        }

        static int[,] FillCellsMatrixFromOutputFile(StreamReader readMatrix, string currentRow, int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            { 
                string[] numbersAsString = readMatrix.ReadLine().Split(' ');

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(numbersAsString[col]);
                }
            }
            return matrix;
        }
    }
}
