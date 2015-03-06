using System;

class SumInSequence
{
    static void Main()
    {
        int[] myArray = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

        int lastIndex = 0;
        int firstIndex = 0;
        int sum = 0;
        int maxSum = int.MinValue;

        for (int i = 0; i < myArray.Length; i++)
        {
            sum += myArray[i];

            if (sum < myArray[i])       //Genialen nachin
            {                           //za namirane
                sum = myArray[i];       //na 1viq index
                firstIndex = i;         //v redica
            }                           //

            if (sum > maxSum)
            {
                maxSum = sum;
                lastIndex = i;
            }  
        }

        for (int i = firstIndex; i <=lastIndex; i++)
        {
            Console.Write("{0} ",myArray[i]);
        }
        Console.WriteLine();
    }
}
