using System;

class ByKFind
{
    static void Main()
    {
        //test matrix
        int[,] matrix = 
        {
            {1, 2, 0, 11, 7, 1},
            {7, 8, 2, 51, 0, 1},
            {7, 2, 0, 3, -9, 44},
            {99, 114, 2, 7, -8, 5}
        };


        //Console.Write("Enter row (Count start from 0): ");
        //int k = int.Parse(Console.ReadLine());

        //BiggestElementAboveInputRow(matrix, k);  
             
        //SmallestElementUnderRow(matrix, k);
        
        //Console.WriteLine("Multiply is {0}", MultiplyOnEveryElementsExceptInputRow(matrix,k));

        Console.Write("Enter column (Count start from 0): ");
        int k = int.Parse(Console.ReadLine());
        
        //Console.WriteLine("Multiply is {0}", MultiplyOnEveryElementsExceptInputColumn(matrix, k));

        //SmallestElementBeforeInputColumn(matrix, k); 

        BiggestElementBehindInputColumn(matrix, k);

    }

    static void BiggestElementAboveInputRow(int[,] inputMatrix,int inputRow)
    {
        int max = int.MinValue;
        //if k=0 or k > last row + 1 --> Out of range
        if ((inputRow == 0) || (inputRow >= inputMatrix.GetLength(0)))
        {
            Console.WriteLine("Incorrect input!"); 
        }
        else
        {
            for (int row = inputRow - 1; row >= 0; row--)
            {
                for (int col = 0; col < inputMatrix.GetLength(1); col++)
                {
                    if (inputMatrix[row, col] > max)
                    {
                        max = inputMatrix[row, col];
                    }
                }
            }
            Console.WriteLine("The biggest element above row {0} is {1}",inputRow,max);
        }        
    }

    static void SmallestElementUnderRow(int[,] inputMatrix, int inputRow)
    {
        int mix = int.MaxValue;
        //if k >= last row --> Out of range
        if (inputRow >= inputMatrix.GetLength(0)-1)
        {
            Console.WriteLine("Incorrect input!");
        }
        else
        {
            for (int row = inputRow + 1; row < inputMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < inputMatrix.GetLength(1); col++)
                {
                    if (inputMatrix[row, col] < mix)
                    {
                        mix = inputMatrix[row, col];
                    }
                }
            }
            Console.WriteLine("The smallest element under row {0} is {1}",inputRow,mix);
        }        
    }

    static long MultiplyOnEveryElementsExceptInputRow(int[,] inputMatrix, int inputRow)
    {
        long multiply =1L;
        for (int row = 0; row < inputMatrix.GetLength(0); row++)
        {
            //except input row
            if (row==inputRow)
            {
                continue;
            }
            else
            {
                for (int col = 0; col < inputMatrix.GetLength(1); col++)
                {
                    if (inputMatrix[row,col] !=0)
                    {
                        multiply *= inputMatrix[row, col];
                    }
                }
            }
        }
        return multiply;
    }

    static long MultiplyOnEveryElementsExceptInputColumn(int[,] inputMatrix, int inputCol)
    {
        long multiply = 1L;
        for (int col = 0; col < inputMatrix.GetLength(1); col++)
        {
            //except input column
            if (col == inputCol)                  // if (col != inputCol)
            {                                     // for (int row = 0; row < inputMatrix.GetLength(0); row++)
                continue;                         //    multiply *= inputMatrix[row, col];  
            }                                     //  
            else
            {
                for (int row = 0; row < inputMatrix.GetLength(0); row++)
                {                    
                    multiply *= inputMatrix[row, col];                   
                }
            }
        }
        return multiply;
    }

    static void SmallestElementBeforeInputColumn(int[,] inputMatrix,int inputCol)
    {
        int min = int.MaxValue;
        // check k >= last column --> Out of range
        if (inputCol >= inputMatrix.GetLength(1)-1)
        {
             Console.WriteLine("Incorrect input!"); 
        }
        else
        {
            for (int col = inputCol + 1; col < inputMatrix.GetLength(1); col++)
            {
                for (int row = 0; row < inputMatrix.GetLength(0); row++)
                {
                    if (inputMatrix[row,col] < min)
                    {
                        min = inputMatrix[row, col];
                    }
                }
            }
            Console.WriteLine("The smallest element before column {0} is {1}",inputCol,min);
        }
    }

    static void BiggestElementBehindInputColumn(int[,] inputMatrix,int inputCol)
    {
        int max = int.MinValue;

        if (inputCol==0 || inputCol >= inputMatrix.GetLength(1))
        {
            Console.WriteLine("Incorrect input!"); 
        }
        else
        {
            for (int col = inputCol - 1; col >=0; col--)
            {
                for (int row = 0; row < inputMatrix.GetLength(0); row++)
                {
                    if (inputMatrix[row,col] > max)
                    {
                        max = inputMatrix[row, col];
                    }
                }
            }
            Console.WriteLine("The biggest element behind column {0} is {1}",inputCol,max);
        }
    }
}

