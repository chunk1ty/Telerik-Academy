using System;

class EqualSequence
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[] myArr = new int[size];

        for (int index = 0; index < size; index++)
        {
            myArr[index] = int.Parse(Console.ReadLine());
        }

        int maxSequence = 1;
        int currentSequence = 1;
        int element = 0;

        for (int index = 0; index < myArr.Length-1; index++)
        {
            if (myArr[index] == myArr[index+1])
            {
                currentSequence++;   
            }
            else
            {
                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                    element = myArr[index];
                }
                currentSequence = 1;
            }
            if (currentSequence > maxSequence)
            {
                maxSequence = currentSequence;
                element = myArr[index];
            }
        }

        for (int index = 0; index < maxSequence; index++)
        {
            Console.Write("{0} ",element);
        }
    }
}

