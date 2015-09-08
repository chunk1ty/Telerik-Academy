namespace PathExists
{
    using System;
    public class Program
    {
        //static char[,] matrix = {   {' ', ' ', ' ', '*', ' ', ' ', ' ' },   
        //                            {'*', '*', ' ', '*', ' ', '*', ' ' },
        //                            {' ', ' ', ' ', ' ', ' ', ' ', ' ' }, 
        //                            {' ', '*', '*', '*', '*', '*', ' ' },
        //                            {' ', ' ', ' ', ' ', ' ', ' ', 'E' }
        //                        };

        private static char[,] matrix = new char[100 , 100];        

        //static bool isExist = false;

        static void Main(string[] args)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = ' ';
                }
            }

            matrix[10, 20] = 'E';
            IsPathExist(99, 99);

            //if (isExist)
            //{
            //    Console.WriteLine("The path exists!");
            //}
            //else
            //{
            //    Console.WriteLine("The path doesn't exist");
            //}
        }

        private static void IsPathExist(int row, int col)
        {
            if (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1))
            {
                return;   
            }

            if (matrix[row,col] == 'E')
            {
                Console.WriteLine("The path exists!");
                //isExist = true;
                Environment.Exit(0);    
            }

            if (matrix[row,col] == ' ')
            {
                matrix[row, col] = 'A';

                IsPathExist(row + 1, col);
                IsPathExist(row - 1, col);
                IsPathExist(row, col + 1);
                IsPathExist(row, col - 1);

                matrix[row, col] = ' ';
            }
        }
    }
}