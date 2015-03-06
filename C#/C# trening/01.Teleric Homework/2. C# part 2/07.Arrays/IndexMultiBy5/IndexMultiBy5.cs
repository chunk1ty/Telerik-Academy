using System;

class IndexMultiBy5
{
    static void Main()
    {
        int[] myArray = new int[20];

        for (int index = 0; index < myArray.Length; index++)
        {
            myArray[index] = index * 5;
        }

        foreach (var item in myArray)
        {
            Console.WriteLine(item);
        }
    }
}

