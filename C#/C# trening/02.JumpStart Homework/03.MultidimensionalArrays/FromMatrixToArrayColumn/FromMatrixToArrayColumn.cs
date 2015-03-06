using System;

class FromMatrixToArrayColumn
{
    static void Main()
    {
        int[,] matrix = 
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9},            
        };

        int[] myArray = new int[matrix.GetLength(0) * matrix.GetLength(1)];
        FillArrayWithMatrixElementsByColumn(matrix, myArray);

        Console.Write("Enter row : ");
        int inputRow = int.Parse(Console.ReadLine());
        Console.Write("Enter column : ");
        int inputCol = int.Parse(Console.ReadLine());

        CheckIndexInArray(matrix, myArray, inputRow, inputCol);

        //int rows = matrix.GetLength(0);
        //int cols = matrix.GetLength(1);

        //int i = 1;
        //int j = 4;

        //int k = j * rows + i;

    }

    static void CheckIndexInArray(int[,] matrix, int[] myArray, int inputRow, int inputCol)
    {
        for (int i = 0; i < myArray.Length; i++)
        {
            if (matrix[inputRow, inputCol] == myArray[i])
            {
                Console.WriteLine("Index in array is {0}", i);
                break;
            }
        }
    }

    static void FillArrayWithMatrixElementsByColumn(int[,] matrix, int[] myArray)
    {
        int index = 0;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                myArray[index] = matrix[row, col];
                index++;
            }
        }
    }
}

