using System;

namespace FirstBiggerNumberThanItsNeighbors
{
    class NumberBiggerThanNeighbors
    {
        static void Main()
        {
            int[] myArray = { 1, 2, 5, 17, 19, 31, 2, 13, 31, 17 };
            Console.WriteLine(CheckPosition(myArray));
        }

        static int CheckPosition(int[] array)
        {
            for (int pos = 1; pos < array.Length - 1; pos++)
            {
                if (((array[pos] > array[pos - 1])) && (array[pos] > array[pos + 1]))
                {
                    return pos;
                }
            }
            return -1;
        }
    }
}
