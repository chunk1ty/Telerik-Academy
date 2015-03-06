using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessProblemTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 8;
            int p1 = 2;
            int q1 = 2;
            int p2 = 4;
            int q2 = 7;

            int[,] matrix = new int[8, 8];
            matrix[p1, q1] = 1;
            matrix[p2, q2] = 1;

            int distanceX = Math.Abs(p1 - p2);
            int distanceY = Math.Abs(q1 - q2);

            int moveDirX = Math.Sign(p2 - p1);
            int moveDirY = Math.Sign(q2 - q1);

            int x = p1;
            int y = q1;

            if (distanceX <= distanceY)
            {
                while (x != p2)
                {
                    matrix[x, y] = 1;
                    x += moveDirX;
                    y += moveDirY;
                }
                while (y != q2)
                {
                    matrix[x, y] = 1;
                    y += moveDirY;
                }
            }
            else 
            {
                while (y != q2)
                {
                    matrix[x, y] = 1;
                    x += moveDirX;
                    y += moveDirY;
                }

                while (x != p2)
                {
                    matrix[x, y] = 1;
                    x += moveDirX;
                }
            }
            //else
            //{
            //    while (x != p2)
            //    {
            //        matrix[x, y] = 1;
            //        x += moveDirX;
            //        y += moveDirY;
            //    }
            //}






            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    Console.Write("{0} ",matrix[row,col]);
                }
                Console.WriteLine();
            }

        }
    }
}
