using System;

class DefineArray
{
    static void Main()
    {
        int[] myArray = { 1,2,3,4,5,5 };

        bool isAllEqual = true;
        bool isIncreasing = true;
        bool isStrictlyIncreasing = true;
        bool isDecreasing = true;
        bool isStrictlyDecreasing = true;

        for (int i = 0; i < myArray.Length-1; i++)
        {
            int j = i + 1;
            if (myArray[i] != myArray[j])
            {
                isAllEqual = false;
            }
            if (myArray[i] < myArray[j])
            {
                isDecreasing = false;
            }
            if (myArray[i] <= myArray[j])
            {
                isStrictlyDecreasing = false;
            }
            if (myArray[i] > myArray[j])
            {
                isIncreasing = false;
            }
            if (myArray[i] >= myArray[j])
            {
                isStrictlyIncreasing = false;
            }
        }
        if (isAllEqual)
        {
            Console.WriteLine("All Equal");
        }
        else if (isIncreasing)
        {
            Console.WriteLine("Increasing");
        }
        else if (isStrictlyIncreasing)
        {
            Console.WriteLine("Strictly Increasing");
        }
        else if (isDecreasing)
        {
            Console.WriteLine("Decreaing");
        }
        else if (isStrictlyDecreasing)
        {
            Console.WriteLine("Strictly Decreasing");
        }
        else
        {
            Console.WriteLine("Unsortted");
        }
    }
}

