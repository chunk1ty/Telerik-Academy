using System;

namespace CheckNumbersNeighbors
{
    class NumberBetweenNumbers
    {
        static void Main()
        {
            int[] myArray = { 1, 21, 5, 17, 19, 31, 2, 13, 31, 17 };
            int position = 1;

            if (CheckPosition(myArray,position))
            {
                CheckIsNumberIsBiggerThanNeighbors(myArray, position);
            }
        }

        static bool CheckPosition(int[] array, int pos)
        {
            if (pos == 0 || pos == array.Length - 1)
            {
                return false;
            }            
            return true;
        }

        static void CheckIsNumberIsBiggerThanNeighbors(int[] inputArray,int index)
        {
            if (inputArray[index] > inputArray[index + 1] && inputArray[index] > inputArray[index - 1])
            {
                Console.WriteLine("Number {0} is greater than its neighbors",inputArray[index]);
            }
            else
            {
                Console.WriteLine("Number {0} is not greater than its neighbors", inputArray[index]);
            }
        }
    }
}

