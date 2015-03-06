using System;

class FindSumOfEndElement
{
    static void Main()
    {
        //test matrix
        int[,] matrix = 
        {
            {1, 2, 0, 1, 7, 1},                  //1 + 2 + 0 + 1 + 7 + 1 
            {7, 8, 2, 5, 0, 1},                  //7                   1        
            {7, 2, 0, 3, 9, 4},                  //7                   4 
            {9, 4, 2, 7, -8, 5}                  //9 + 4 + 2 +7 - 8 +  5
        };       

        int lengthRow = matrix.GetLength(0);      //4
        int lengthCol = matrix.GetLength(1);      //6
        
        int sumDown = MoveDown(matrix, lengthRow);        
        int sumRigth = MoveRigth(matrix, lengthRow, lengthCol);
        int sumUp = MoveUp(matrix, lengthRow, lengthCol);
        int sumLeft = MoveLeft(matrix, lengthCol);
        int sum = sumDown + sumRigth + sumUp + sumLeft;

        Console.WriteLine("The sum of ends elements of matrix is {0}", sum);
    }

     static int MoveLeft(int[,] matrix, int lengthCol)
    {
        int sumLeft = 0;
        for (int row = 0; row < 1; row++)
        {
            for (int col = lengthCol - 2; col >= 1; col--)
            {
                sumLeft += matrix[row, col];
            }
        }
        return sumLeft;
    }

     static int MoveUp(int[,] matrix, int lengthRow, int lengthCol)
    {
        int sumUp = 0;
        for (int col = lengthCol - 1; col < lengthCol; col++)
        {
            for (int row = lengthRow - 2; row >= 0; row--)
            {
                sumUp += matrix[row, col];
            }
        }
        return sumUp;
    }

     static int MoveRigth(int[,] matrix, int lengthRow, int lengthCol)
    {
        int sumRigth = 0;
        for (int row = lengthRow - 1; row < lengthRow; row++)
        {
            for (int col = 1; col < lengthCol; col++)
            {
                sumRigth += matrix[row, col];
            }
        }
        return sumRigth;
    }

     static int MoveDown(int[,] matrix, int lengthRow)
    {
        int sum = 0;
        for (int col = 0; col < 1; col++)
        {
            for (int row = 0; row < lengthRow; row++)
            {
                sum += matrix[row, col];
            }
        }
        return sum;
    }
}
            // vzemam 2 te kraini reda sled tova 2 te kraini koloni
            // za redove
            //for (int row = 0; row < getlength(1) ; row++)
            //{
            //    sum += a[0,i];
            //    sum += a[row-1,i];
            //}

