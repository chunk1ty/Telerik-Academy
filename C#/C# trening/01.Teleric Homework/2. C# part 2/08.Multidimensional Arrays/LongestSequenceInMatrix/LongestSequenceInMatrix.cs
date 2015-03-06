using System;

class LongestSequenceInMatrix
{
    static void PrintMatrix(string[,] myMatrix)
    {
        for (int row = 0; row < myMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < myMatrix.GetLength(1); col++)
            {
                Console.Write("{0,-4} ",myMatrix[row,col]);
            }
            Console.WriteLine();
        }
    }

    static string[] CheckColumn(string[,] myMatrix)
    {
        int curentSequence = 1;
        int longestSequence = 0;
        string stringValue = null;
        string longestStringValue = null;

        for (int col = 0; col < myMatrix.GetLength(1); col++)
        {
            curentSequence = 1;
            for (int row = 0; row < myMatrix.GetLength(0) - 1; row++)
            {
                if (myMatrix[row, col] == myMatrix[row + 1, col])
                {
                    curentSequence++;
                    stringValue = myMatrix[row, col];
                }
                else
                {
                    if (curentSequence > longestSequence)
                    {
                        longestSequence = curentSequence;
                        longestStringValue = stringValue;
                    }
                    curentSequence = 1;
                }
            }
            if (curentSequence > longestSequence)
            {
                longestSequence = curentSequence;
                longestStringValue = stringValue;
            }
        }

        string[] maxSequence = new string[longestSequence];
        for (int i = 0; i < maxSequence.Length; i++)
        {
            maxSequence[i] = longestStringValue;
        }
        return maxSequence;
    }

    static string[] CheckRow(string[,] myMatrix)
    {
        int curentSequence = 1;
        int longestSequence = 0;
        string stringValue = null;
        string longestStringValue = null;

        for (int row = 0; row < myMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < myMatrix.GetLength(1) - 1; col++)
            {
                if (myMatrix[row, col] == myMatrix[row, col + 1])
                {
                    curentSequence++;
                    stringValue = myMatrix[row, col];
                }
                else
                {
                    if (curentSequence > longestSequence)
                    {
                        longestSequence = curentSequence;
                        longestStringValue = stringValue;
                    }
                    curentSequence = 1;
                }
            }
            if (curentSequence > longestSequence)
            {
                longestSequence = curentSequence;
                longestStringValue = stringValue;
            }
        }

        string[] maxSequence = new string[longestSequence];
        for (int i = 0; i < maxSequence.Length; i++)
        {
            maxSequence[i] = longestStringValue;
        }
        return maxSequence;
    }

    static void Main()
    {
        string[,] stringMatrix =
        {
            {"ha", "hi"  ,"ha", "ha"  , "xx"   },
            {"ha", "ha"  ,"ha", "xx"  , "xx"   },
            {"ha", "ha"  ,"xx", "hi"  , "hi"   },
            {"ha", "xao" ,"hi", "xxs" , "xxs"  },
           // {"xx", "xx"  ,"xx", "hi"},
        };
        //PrintMatrix(stringMatrix);

        //string[] column = CheckColumn(stringMatrix);
        //string[] rows = CheckRow(stringMatrix);

        //if (column.Length > rows.Length)
        //{
        //    for (int i = 0; i < column.Length; i++)
        //    {
        //        Console.Write("{0} ", column[i]);
        //    }
        //}
        //else
        //{
        //    for (int i = 0; i < rows.Length; i++)
        //    {
        //        Console.Write("{0} ", rows[i]);
        //    }
        //}
        //Console.WriteLine();

    }
}

