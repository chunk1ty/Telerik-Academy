using System;
using System.Linq;

class BinSearch
{
    static void Main()
    {
        int[] myArray = { 1, 25, 17, 39, 19, 23, 109, -24, -90, 24 };
        int k = 0;
        Array.Sort(myArray);         // -90 -24 1 17 19 23 24 25 39 109
        
        int index = Array.BinarySearch(myArray, k);

        if (index > 0)
        {
            Console.WriteLine(myArray[index]);
        }

        if (index < 0)
        {
            Console.WriteLine(myArray[-index - 2]);
        }
        
    }
}

