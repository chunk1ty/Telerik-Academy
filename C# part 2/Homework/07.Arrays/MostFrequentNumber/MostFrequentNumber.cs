using System;

class MostFrequentNumber
{
    static void Main()
    {
        //My Solution
        //int[] myArray = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        //int[] myArray = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

        //int value = 0; 
        //int count = 1;
        //int mostFrequentIndex = 0;
        //int mostFrequentNumber = 0;

        //for (int i = 0; i < myArray.Length; i++)
        //{
        //    value = myArray[i];
        //    for (int j = i + 1; j < myArray.Length - 1; j++) 
        //    {
        //        if (value == myArray[j])
        //        {
        //            count++;
        //            continue;
        //        }    
        //    }

        //    if (count > mostFrequentIndex)
        //    {
        //        mostFrequentIndex = count;
        //        mostFrequentNumber = myArray[i];
        //    }  
        //    count = 1;
        //}

        //Console.WriteLine("The most frequent number is {0}. He is frequent {1} times",mostFrequentNumber,mostFrequentIndex);

        //Better Solution

        int[] myArray = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        //int[] myArray = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

        Array.Sort(myArray);
        int count = 1;
        int maxCount = int.MinValue;
        int mostFrequenceNumber = 0;

        for (int i = 1; i < myArray.Length; i++)
        {
            if (myArray[i - 1] == myArray[i])
            {
                count++;  
            }
            else
            {
                count = 1;
            }
            if (count > maxCount)
            {
                maxCount = count;
                mostFrequenceNumber = myArray[i];
            }
        }

        Console.WriteLine("The most frequent number is {0}. He is frequent {1} times",mostFrequenceNumber,maxCount);

    }
}

