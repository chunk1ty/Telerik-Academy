using System;
using System.Text;

class MaxSequence
{
    static void Main()
    {
        int[] myArray = { 2, 3, -6, 36, 12, -1, 6, 4, -8, 8 };
        int currentSum = 0;
        int bestSum = int.MinValue;
        StringBuilder bestSequenceBuild = new StringBuilder();
        string bestSequnce = "";
        for (int i = 0; i < myArray.Length; i++)
        {
            currentSum = currentSum + myArray[i];
            bestSequenceBuild.AppendFormat("{0}, ", myArray[i]);
            if (currentSum > bestSum)
            {
                bestSum = currentSum;
                bestSequnce = bestSequenceBuild.ToString();
            }
            if (currentSum < 0)
            {
                currentSum = 0;
                bestSequenceBuild.Clear();
            }
        }
        Console.WriteLine("The best sequence is: \" {0} \" ", bestSequnce);
        Console.WriteLine("The best sum is: {0} ", bestSum);
    }
}