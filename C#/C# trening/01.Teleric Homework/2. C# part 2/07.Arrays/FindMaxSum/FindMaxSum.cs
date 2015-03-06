using System;

class FindMaxSum
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int[] myArray = new int[n];

        for (int index = 0; index < myArray.Length; index++)
        {
            myArray[index] = int.Parse(Console.ReadLine());
        }

        //int k = 4;
        //int[] myArray = { 6, 3, -17, 19, 1, 2, 7 };

        int maxIndex = 0;
        int maxSeq = int.MinValue;
        int sum = 0;

        for (int i = 0; i < k; i++)
        {
            for (int index = i; index <= k + i - 1; index++)
            {
                sum += myArray[index];
            }
            if (sum > maxSeq)
            {
                maxSeq = sum;
                maxIndex = k + i - 1;
            }
            sum = 0;
        }

        for (int i = maxIndex - k + 1; i < maxIndex + 1; i++)
        {
            Console.Write("{0} ", myArray[i]);
        }
        Console.WriteLine();
        Console.WriteLine("The max sum is " + maxSeq);
        
    }
}

