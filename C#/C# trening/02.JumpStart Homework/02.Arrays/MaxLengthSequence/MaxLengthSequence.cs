using System;

class MaxLengthSequence
{
    static void Main()
    {
        //int[] myArray = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

        int size = int.Parse(Console.ReadLine());
        int[] myArray = new int[size];

        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = int.Parse(Console.ReadLine());
        }

        int currentLength = 1;
        int maxLength = 0;
        int index = 0;

        for (int i = 0; i < myArray.Length-1; i++)
        {
            currentLength = 1;
            for (int j = i + 1; j < myArray.Length; j++)
            {
                if (myArray[i] == myArray[j])
                {
                    currentLength++;
                    index = j;
                }
                else
                {
                    break;
                }   
            }
            if (currentLength > maxLength)
            {
                maxLength = currentLength;
            }
        }

        for (int i = index - maxLength + 1; i <= index; i++)
        {
            Console.Write("{0} ", myArray[i]);
        }
        Console.WriteLine();
        //Console.WriteLine(index);
        //Console.WriteLine(maxLength);
    }
}
