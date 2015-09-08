using System;

class FindMaximalElement
{
    static void Main()
    {
        int[] myArray = { 1, 17, -1, 3, 31, 27, 69, 43, -5, 7, 8 };

        int indexInput = 8;
        Console.WriteLine("The bist number after index {0} is {1}", indexInput - 1, MaxElementFromInputIndex(myArray, indexInput));

        SelectionSort(myArray);
        PrintArray(myArray);

    }

    static void PrintArray(int[] myArray)
    {
        foreach (var item in myArray)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }

    static void SelectionSort(int[] myArray)
    {
        int minIndex;
        int temp;
        for (int i = 0; i < myArray.Length - 1; i++)
        {
            minIndex = i;
            for (int index = i + 1; index < myArray.Length; index++)
            {
                if (myArray[index] < myArray[minIndex])                     // only change < on > for descending
                {
                    minIndex = index;
                }
            }
            temp = myArray[i];
            myArray[i] = myArray[minIndex];
            myArray[minIndex] = temp;
        }
    }

    static int MaxElementFromInputIndex(int[] array,int inputIndex)
    {
        int max = array[inputIndex];
        for (int i = inputIndex; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }
}

