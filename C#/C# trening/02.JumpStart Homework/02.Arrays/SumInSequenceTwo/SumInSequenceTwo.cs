using System;

class SumInSequenceTwo
{
    static void Main()
    {
        int[] myArray = { 4, 3, 1, 4, 2, 5, 4, 1, 10, 11, 2, 1, 8 };
        int s = 11;

        int sum = 0;

        for (int i = 0; i < myArray.Length; i++)
        {
            for (int j = i; j < myArray.Length; j++)
            {
                sum += myArray[j];
                if (sum == s)
                {
                    for (int k = i; k <= j; k++)
                    {
                        Console.Write("{0} ",myArray[k]);
                    }
                    Console.WriteLine();
                    sum = 0;
                    break;
                }
                if (sum > s)
                {
                    sum = 0;
                    break;
                }
            }
        }
    }
}

