using System;

class SelectionSort
{
    static void Main()
    {
        int[] myArray = { 0, -17, 9, 0, -12, -87, 15 };

        int minIndex;
        int temp;
        for (int i = 0; i < myArray.Length-1; i++)
        {
            minIndex = i;
            for (int index = i + 1; index < myArray.Length; index++)
            {
                if (myArray[index] < myArray[minIndex])
                {
                    minIndex = index;
                }
            }
            temp = myArray[i];
            myArray[i] = myArray[minIndex];
            myArray[minIndex] = temp;
        }

        foreach (var item in myArray)
        {
            Console.Write("{0} ",item);
        }
        Console.WriteLine();
    }
}

