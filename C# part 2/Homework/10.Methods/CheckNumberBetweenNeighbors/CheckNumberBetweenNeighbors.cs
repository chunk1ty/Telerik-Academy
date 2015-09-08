using System;

class CheckNumberBetweenNeighbors
{
    static void Main()
    {
        int[] myArray = { 1, 2, 5, 17, 19, 31, 2, 13, 31, 17 };
        int position = 0;
        Console.WriteLine(CheckPosition(myArray,position));
    }

    static bool CheckPosition (int[] array,int pos)
    {
        if (pos == 0 || pos == array.Length - 1)
        {
            return false;
        }
        else if (((array[pos] > array[pos-1])) && (array[pos] > array[pos+1]))
        {
            return true;
        }
        return false;
    }
}
