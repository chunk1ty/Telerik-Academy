using System;

class AverageGradeOfClass
{
    static void Main()
    {
        // subject(M) = rows students(N) = colums
        // i gave 1 if the student cheat and teacher catch him
        int[,] matrix =
        {
            {2,3,6,6},
            {3,4,5,1},
            {3,3,6,0}
        };

       StudentSuccess(matrix);

       SuccessInEachSubjectAndAverage(matrix);
    }

    static void SuccessInEachSubjectAndAverage(int[,] matrix)
    {
        decimal success = 0.0M;
        decimal sumSuccess = 0.0M;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int sum = 0;
            int count = 0;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] >= 1)
                {
                    sum += matrix[row, col];
                    count++;
                }
            }
            if (count > 0)
            {
                success = (decimal)sum / count;
                sumSuccess += success;
                Console.WriteLine("Subject {0} success {1:F2}", row + 1, success); 
            }
            else
            {
                Console.WriteLine(" nqma izpitani po tozi predmet");
            }
                        
        }
        Console.WriteLine();
        decimal average = sumSuccess / matrix.GetLength(0);
        Console.WriteLine("The average success is {0:F2}", average);
    }

    static void StudentSuccess(int[,] matrix)
    {
        decimal success = 0.0M;

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            int sum = 0;
            int count = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (matrix[row, col] >= 1)
                {
                    sum += matrix[row, col];
                    count++;
                }
            }
            if (count > 0)
            {
                success = (decimal)sum / count;
                Console.WriteLine("Student {0} has success {1:F2}", col + 1, success);
            }
            else
            {
                Console.WriteLine("The student doesn't has marks");
            }
            
        }
        Console.WriteLine();
    }
}

