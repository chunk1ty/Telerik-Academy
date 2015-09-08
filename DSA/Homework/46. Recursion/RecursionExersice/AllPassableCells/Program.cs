namespace AllPassableCells
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using LargestAreaOfEmptyCells;

    public class Program
    {
        private static int[,] matrix = new int[10, 10];
        private static HashSet<Point> setOfEmptyCells = new HashSet<Point>();
        static void Main(string[] args)
        {
            matrix = FillMatrixWithElements();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col] != 1)
                    {
                        FindPath(row, col);
                    }
                }
            }

            PrintMatrix();
        }

        private static void FindPath(int row,int col)
        {
            if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
            {
                return;
            }

            if (matrix[row,col] == 0)
            {
                matrix[row, col] = 1;
                setOfEmptyCells.Add(new Point(row, col));

                FindPath(row + 1, col); //down
                FindPath(row, col + 1); //right
                FindPath(row - 1, col); //up
                FindPath(row, col - 1); // left
            }
        }

        private static int[,] FillMatrixWithElements()
        {
            Random rnd = new Random();

            int MatrixRows = matrix.GetLength(0);
            int MatrixCols = matrix.GetLength(1);
            int count = rnd.Next(50, 80);

            for (int i = 0; i < count; i++)
            {
                matrix[rnd.Next(0, MatrixRows), rnd.Next(0, MatrixCols)] = 1;
            }

            return matrix;
        }

        private static void PrintMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.ForegroundColor = ConsoleColor.White;

                    if (matrix[row, col] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    if (setOfEmptyCells.Contains(new Point(row,col)))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        matrix[row, col]--;
                    }

                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}