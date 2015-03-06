using System;
using System.Linq;

class MostCommonNumber
{
    static void Main()
    {
        int[] myArray = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

        Array.Sort(myArray);

        int count = 1;
        int maxLength = 0;
        int value = 0;

        for (int index = 0; index < myArray.Length - 1; index++)
        {
            count = 1;
            for (int i = index + 1; i < myArray.Length; i++)
            {
                if (myArray[index] == myArray[i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            if (count > maxLength)
            {
                maxLength = count;
                value = myArray[index];
            }
        }
        Console.WriteLine("{0} {1}",value,maxLength);  
    }
}

