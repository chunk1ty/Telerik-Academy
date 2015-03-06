using System;

class MergeSort
{
    static void Main()
    {
        int[] myArray = { 2, 4, 1, 6, 8, 5, 3, 7 };
        MergeSortFunction(myArray);

        foreach (var item in myArray)
        {
            Console.Write("{0} ",item);
        }
        
    }

    public static void MergeSortFunction(int[] myArray)
    {
        int lenght = myArray.Length;
        if (lenght < 2)
        {
            return;
        }
        int middle = lenght / 2;
        int[] leftArray = new int[middle];
        int[] rightArray = new int[lenght - middle];

        for (int i = 0; i < middle; i++)
        {
            leftArray[i] = myArray[i];
        }

        int j = 0;
        for (int i = middle; i < lenght; i++)
        {
            rightArray[j] = myArray[i];
            j++;
        }
        MergeSortFunction(leftArray);
        MergeSortFunction(rightArray);
        Merge(leftArray, rightArray, myArray);
    }

    public static void Merge(int[] leftArray,int[] rightArray,int[] myArray)
    {
        int lengthLeft = leftArray.Length;
        int lengthRight = rightArray.Length;
        int indexLeftArray = 0;
        int indexRightArray = 0;
        int indexOriginalArray = 0;

        while (indexLeftArray < lengthLeft && indexRightArray < lengthRight)
        {
            if (leftArray[indexLeftArray] <= rightArray[indexRightArray])
            {
                myArray[indexOriginalArray] = leftArray[indexLeftArray];
                indexLeftArray++;
                indexOriginalArray++;
            }
            else
            {
                myArray[indexOriginalArray] = rightArray[indexRightArray];
                indexOriginalArray++;
                indexRightArray++;
            }
        }
        while (indexLeftArray < lengthLeft)
        {
            myArray[indexOriginalArray] = leftArray[indexLeftArray];
            indexLeftArray++;
            indexOriginalArray++;
        }
        while (indexRightArray < lengthRight)
        {
            myArray[indexOriginalArray] = rightArray[indexRightArray];
            indexOriginalArray++;
            indexRightArray++;
        }
            
    }
}

