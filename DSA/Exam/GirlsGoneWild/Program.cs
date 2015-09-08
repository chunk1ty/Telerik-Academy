using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portals
{
    class Program
    {
        static string[,] board;
        static bool[,] visited;
        static int rows;
        static int cols;
        static List<int> list = new List<int>();
        static int maxSum = 0;
        static int currentSum = 0;

        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split(' ');
            int startPositionX = int.Parse(firstLine[0]);
            int startPositionY = int.Parse(firstLine[1]);
            string[] secondLine = Console.ReadLine().Split(' ');
            rows = int.Parse(secondLine[0]);
            cols = int.Parse(secondLine[1]);

            board = new string[rows, cols];
            visited = new bool[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] currentLine = Console.ReadLine().Split(' ');
                for (int col = 0; col < cols; col++)
                {
                    board[row, col] = currentLine[col];
                }
            }

            Solver(startPositionX, startPositionY);

            Console.WriteLine(maxSum);
        }

        public static void Solver(int positionX, int positionY)
        {
            if (!IsInRange(positionX, positionY))
            { 
                return;
            }

            if (board[positionX, positionY] == "#" )
            {
                return;
            }

            if (maxSum < currentSum)
            {
                maxSum = currentSum;
            }

            if (visited[positionX, positionY])
            {
                return;
            }

            int number = int.Parse(board[positionX, positionY]);
            visited[positionX, positionY] = true;

            currentSum += number;

            Solver(positionX + number, positionY);
            Solver(positionX - number, positionY);
            Solver(positionX, positionY + number);
            Solver(positionX, positionY - number);

            currentSum -= number;
            visited[positionX, positionY] = false;

        }

        private static bool IsInRange(int row, int col)
        {
            if (row < 0 || row >= board.GetLength(0))
            {
                return false;
            }

            if (col < 0 || col >= board.GetLength(1))
            {
                return false;
            }

            return true;
        }
    }
}
