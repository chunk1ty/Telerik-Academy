namespace AllPathsInMatrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        //static char[,] matrix = {   {' ', ' ', ' ', '*', ' ', ' ', ' ' },   
        //                            {'*', '*', ' ', '*', ' ', '*', ' ' },
        //                            {' ', ' ', ' ', ' ', ' ', ' ', ' ' }, 
        //                            {' ', '*', '*', '*', '*', '*', ' ' },
        //                            {' ', ' ', ' ', ' ', ' ', ' ', 'E' }
        //                        };

        static char[,] matrix = {  
                                    {' ', ' ', ' ',},   
                                    {' ', '*', ' ',},
                                    {' ', ' ', 'E',}
                                };


        static List<char> paths = new List<char>();

        static void Main(string[] args)
        {
            FindAllPaths(0, 0, 'X');
        }

        private static void FindAllPaths(int row, int col, char direction)
        {
            if (!IsInRange(row, col))
            {
                return;
            }

            if (matrix[row,col] == 'E')
            {
                PrintPath();
            }

            if (matrix[row,col] == ' ')
            {
                paths.Add(direction);
                matrix[row, col] = 'A';
                FindAllPaths(row + 1, col, 'D');
                FindAllPaths(row - 1, col, 'U');
                FindAllPaths(row, col + 1, 'R');
                FindAllPaths(row, col - 1, 'L');

                paths.RemoveAt(paths.Count - 1);
                matrix[row,col]= ' ';
            }
        }

        private static void PrintPath()
        {
            Console.Write("Exit N {0} --> ");
            foreach (char item in paths)
            {
                if (item != 'X')
                {
                    Console.Write(item);
                }
            }
            Console.WriteLine();
        }

        private static bool IsInRange(int row, int col)
        {
            if (row < 0 || row >= matrix.GetLength(0))
            {
                return false;
            }

            if (col < 0 || col >= matrix.GetLength(1))
            {
                return false; 
            }

            return true;
        }
    }
}
