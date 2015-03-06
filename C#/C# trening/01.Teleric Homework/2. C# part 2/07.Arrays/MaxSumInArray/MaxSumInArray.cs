using System;

class MaxSumInArray
{
    static void Main()
    {
        int[] myArray = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        //int[] myArray = { 2, 3, -6, 36, 12, -1, 6, 4, -8, 8 };

        int sum = 0;
        int maxSum = int.MinValue;
        int lastIndex = -1;
        int firstIndex = 0;

        for (int i = 0; i < myArray.Length; i++)
        {
            sum += myArray[i];
            if (sum < myArray[i])
            {
                sum = myArray[i];
                firstIndex = i;
            }
            if (sum > maxSum)
            {
                maxSum = sum; 
                lastIndex = i;   
            }  
        }

        for (int i = firstIndex; i < lastIndex + 1; i++)
        {
            Console.Write("{0} ", myArray[i]);
        }
        Console.WriteLine();
        Console.WriteLine("The max sum is {0}",maxSum);
        
    }
}

