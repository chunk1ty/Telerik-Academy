using System;

class PrintMatrix
{
    static void MatrixA(int[,] myMatrix,int size)
    {
        int counter = 1;
        for (int col = 0; col < size; col++)
        {
            for (int row = 0; row < size; row++)
            {
                myMatrix[row, col] = counter;
                counter++;
            }
        }
        PrintCurrentMatrix(myMatrix,size);
    }

    static void MatrixB(int[,] myMatrix, int size)
    {
        int counter = 1;
        for (int col = 0; col < size; col++)
        {
            for (int row = 0; row < size; row++)
            {
                if (col % 2 == 0)
                {
                    myMatrix[row, col] = counter;
                    counter++;
                }
                else
                {
                    myMatrix[size - row - 1, col] = counter;
                    counter++;
                }
            }
        }
        PrintCurrentMatrix(myMatrix, size);
    }

    static void MatrixC(int[,] myMatrix, int size)
    {
        int counter = 1;
        for (int row = size - 1; row >= 0; row--)
        {
            for (int col = 0; col < size - row; col++)
            {
                myMatrix[row + col, col] = counter;
                counter++;
            }
        }

        for (int col = 1; col < size; col++)
        {
            for (int row = 0; row < size - col; row++)
            {
                myMatrix[row, col+row] = counter;
                counter++;
            }
        }

        PrintCurrentMatrix(myMatrix, size);
    }

    static void MatrixD(int[,] myMatrix, int size)
    {
        int counter = 1;
        int row = 0;
        int col = 0;
        int position = 0;

        while (counter <= size * size) 
        {
            //Move down
            for (row = position; row < size - position; row++)
            {
                col = position;
                myMatrix[row, col] = counter;
                counter++;
            }
            //Move left
            for (col = position + 1; col < size - position; col++)
            {
                row = size - position - 1;
                myMatrix[row, col] = counter;
                counter++;
            }
            //Move up
            for (row = size - position - 2; row >= position; row--)
            {
                col = size-position - 1;
                myMatrix[row, col] = counter;
                counter++;
            }
            //Move left
            for (col = size - position - 2; col >= position + 1; col--)
            {
                row = position;
                myMatrix[row, col] = counter;
                counter++;
            }
            position++;
        }
        PrintCurrentMatrix(myMatrix, size);
    }

    static void PrintCurrentMatrix(int[,] myMatrix, int size)
    {
        for (int row = 0; row < myMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < myMatrix.GetLength(1); col++)
            {
                Console.Write("{0,-3} ",myMatrix[row,col]);
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int n = 7;
        int[,] matrix = new int[n, n];

       //MatrixA(matrix, n);
       //MatrixB(matrix, n);
       //MatrixC(matrix, n);
        MatrixD(matrix, n);
       
       
    }
}

