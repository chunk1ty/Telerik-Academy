using System;

class EvenValueInArray
{
    static void Main()
    {
        int[] myArray = { 7, 1, 1, 2, 9, 5, 1, 6, 4, 7 };

        for (int index = 0; index < myArray.Length; index++)
        {
            if (myArray[index] % 2 == 0)
            {
                Console.Write("{0} ", index);
            }
        }
        Console.WriteLine();
    }
}

