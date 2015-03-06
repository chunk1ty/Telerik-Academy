using System;

class FindSequenceOfGivenSum
{
    static void Main()
    {
        int[] myArray = { 4, 3, 1, 4, 2, 5, 8 };
        int S = 11;

        //int S = int.Parse(Console.ReadLine());
        //int n = int.Parse(Console.ReadLine());
        //int[] myArray = new int[n];

        //for (int index = 0; index < myArray.Length; index++)
        //{
        //    myArray[index] = int.Parse(Console.ReadLine());
        //}

        int sum = 0;
        //int lenCurrent = 0;            Comment lines is my solution, but another is better.
        //int lastIndex = 0;

        for (int i = 0; i < myArray.Length; i++)
        {
            for (int j = i; j < myArray.Length; j++)
            {
                sum += myArray[j];
               // lenCurrent++;
                if (sum > S)
                {
                    sum = 0;
                   // lenCurrent = 0;
                    break;
                }
                if (sum == S)
                {
                    //lastIndex = j;   
                    for (int print = i; print < j+1; print++)
                    {
                        Console.Write("{0} ",myArray[print]);
                    }
                    Console.WriteLine();
                    break;
                }
            }
            if (sum == S)
            {
                break;
            }
        }

        //for (int i = lastIndex - lenCurrent + 1; i < lastIndex + 1; i++)
        //{
        //    Console.Write("{0} ",myArray[i]);
        //}
        //Console.WriteLine();
       

    }
}

