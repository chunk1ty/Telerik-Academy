using System;

class FindPositionOfFirstNegativeNumber
{
    static void Main()
    {
        int[] myArray = { 9, 4, -1, 8, 7, -2, -7 };

        int i = 0;
        while (i < myArray.Length && myArray[i] >= 0)
        {
            i++;
        }
        if (i==myArray.Length)
        {
            Console.WriteLine("There is no negative elements in the array");
        }
        else
        {
            int counter = 1;
            for (int j = 0; j < myArray.Length; j++)
            {
                if (myArray[j]<0)
                {
                    counter++;
                }
            }
            Console.WriteLine("The index of the first negative element is {0} and  the total number of all negative numbers is {1}",i,counter);
        }

    }
}

