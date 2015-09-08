using System;

class QuickSort
{
    static void Main()
    {
        int[] myArray = { 7, 2, 1, 6, 8, 5, 3, 4 };

        QuickSortFunction(myArray, 0, myArray.Length - 1);

        foreach (var item in myArray)
        {
            Console.Write("{0} ",item);
        }
        Console.WriteLine();
    }
   
    private static void QuickSortFunction (int[] someArray,int startIndex,int endIndex)
    {
        if (startIndex < endIndex)
        {
            int partitionIndex = Partition(someArray, startIndex, endIndex);
            QuickSortFunction(someArray, startIndex, partitionIndex-1);
            QuickSortFunction(someArray, partitionIndex + 1, endIndex);
        }     
    }

    private static int Partition (int[] someArray,int startIndex,int endIndex)         //startIdex = 0 endIndex = 7
    {
        int pivotValue = someArray[endIndex];      //pivotValue = 4
        int partitionIndex = startIndex;           //pivotIndex = 0

        for (int i = startIndex; i < endIndex; i++)
        {
            if (pivotValue >= someArray[i])
            {
                Swap(partitionIndex,i,someArray);
                partitionIndex++;
            }   
        }
        Swap(endIndex, partitionIndex, someArray);

        return partitionIndex;
    }

    private static void Swap(int indexOne,int indexTwo,int[] someArray)
    {
        int temp = someArray[indexOne];
        someArray[indexOne] = someArray[indexTwo];
        someArray[indexTwo] = temp;
    }
}

