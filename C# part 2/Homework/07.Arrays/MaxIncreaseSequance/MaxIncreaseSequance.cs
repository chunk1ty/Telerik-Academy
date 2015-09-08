using System;

class MaxIncreaseSequance
{
    static void Main()
    {
        int[] myArray = { 0, 1, 2, 3, 4, 2, 3, 4, 5, 6, 7, 8, 30, 2, 3 };

        int maxSequence = 1;
        int currentSequence = 1;
        int element = 0;

        for (int index = 0; index < myArray.Length - 1; index++)
        {
            if (myArray[index] < myArray[index + 1])
            {
                currentSequence++;   
            }
            else
            {
                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                    element = index ;
                }
                currentSequence = 1;
            }
            
        }

        if (currentSequence > element)
        {
            maxSequence = currentSequence;
            element = myArray.Length - 1;
        } 
        currentSequence = 1;

        for (int i = element - maxSequence + 1; i < element; i++)
        {
            Console.Write("{0} ", myArray[i]);
        }
    }
}
