namespace LargestAreaOfEmptyCells
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        private static int[,] matrix = new int[5, 5];
        private static List<Point> currentSequence = new List<Point>();
        private static int longest = 0;
        private static List<Point> currentLongestSequence = new List<Point>();
        private static List<Point> largestSequence = new List<Point>();

        static void Main(string[] args)
        {
            matrix = FillMatrixWithElements();
            

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    FindPath(row, col);

                    if (largestSequence.Count < currentLongestSequence.Count)
                    {
                        largestSequence = new List<Point>(currentLongestSequence);
                    }
                } 
            }

            PrintMatrix();
        }

        private static void FindPath(int row, int col)
        {
            if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
            {
                return;
            }

            if (longest < currentSequence.Count)
            {
                longest = currentSequence.Count;
                currentLongestSequence = new List<Point>(currentSequence);
            }

            if (matrix[row,col] == 0)
            {
                matrix[row, col] = 2;
                currentSequence.Add(new Point(row, col));

                FindPath(row + 1, col); //down
                FindPath(row, col + 1); //right
                FindPath(row - 1, col); //up
                FindPath(row , col - 1); // left

                currentSequence.RemoveAt(currentSequence.Count - 1);
                matrix[row, col] = 0;
            }
        }
        
        private static int[,] FillMatrixWithElements()
        {
            Random rnd = new Random();

            int MatrixRows = matrix.GetLength(0);
            int MatrixCols = matrix.GetLength(1);
            int decideHelper = MatrixRows * MatrixCols;
            int count = rnd.Next(decideHelper / 4, decideHelper - decideHelper / 4 + 1);

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

                    if (matrix[row,col] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    
                    if (largestSequence.Contains(new Point(row, col)))
                    {                        
                        Console.ForegroundColor = ConsoleColor.Green; 
                    }

                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}