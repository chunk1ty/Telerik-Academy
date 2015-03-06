using System;

class FromMatrixToArray
{
    static void Main()
    {
        //test matrix
        int[,] matrix = 
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9},            
        };

        int[] myArray = new int[matrix.GetLength(0) * matrix.GetLength(1)];
        FillArrayWithMatrixElements(matrix, myArray);

        Console.Write("Enter index: ");
        int index = int.Parse(Console.ReadLine());
        IndexInMatrix(matrix, myArray, index);

        //int rows = matrix.GetLength(0);
        //int cols = matrix.GetLength(1);
        //int i = 8;

        //int row = i / cols;
        //int col = i % cols;

        //int k = row * cols + cols;
    }

    static void IndexInMatrix(int[,] matrix, int[] myArray, int index)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (myArray[index] == matrix[row, col])
                {
                    Console.WriteLine("Row {0}, Colomn {1}", row, col);
                    break;
                }
            }
        }
    }

    static void FillArrayWithMatrixElements(int[,] matrix, int[] myArray)
    {
        int index = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                myArray[index] = matrix[row, col];
                index++;
            }
        }
    }
}

