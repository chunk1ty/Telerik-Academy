using System;

class FindMinElementInArray
{
    static void Main()
    {
        int[] myArray = { 9, 4, 1, 8, 7, 2, 7 };
        int b = 4;

        int i = 0;

        while (i < myArray.Length && myArray[i] <= b) 
        {
            i++;
        }

        if (i == myArray.Length)
	    {
            Console.WriteLine("No number greater than{0} ",b);
	    }
        else
        {
            int min = myArray[i];
            for (int j = i + 1; j < myArray.Length; j++)
            {
                if (min > myArray[j] && myArray[j] > b)
                {
                    min = myArray[j];
                }
            }
            Console.WriteLine("Smallest number greater than {0} is {1}", b, min);

            Console.Write("Position: ");
            for (int j = 0; j < myArray.Length; j++)
            {
                if (min == myArray[j])
                {
                    Console.Write("{0} ",j);
                }
            }
            Console.WriteLine();
        }
    }
}

