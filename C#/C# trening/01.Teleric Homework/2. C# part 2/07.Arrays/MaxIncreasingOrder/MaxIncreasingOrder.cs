using System;

class MaxIncreasingOrder
{
    static void Main()
    {
        int[] myArray = { 1, 4, 3, 0, 3, 6, 4, 5, 6 };
        int[] checkSequence = new int[myArray.Length];
        int[] maxIncreasingOrder = new int[myArray.Length];

        int countIncreasingArray = 0;
        int maxLen = 0;
        int currentLen = 1;
        int startOfSequence = 0;

        for (int index = 0; index < myArray.Length - 1; index++)
        {
            startOfSequence = myArray[index];
            checkSequence[countIncreasingArray] = startOfSequence;

            for (int i = index + 1; i < myArray.Length - 1; i++)
            {
                if (startOfSequence <= myArray[i])
                {
                    int minNextValue = myArray[i];

                    for (int j = i + 1; j < myArray.Length; j++)
                    {
                        if (startOfSequence > myArray[j] )
                        {
                            continue;
                        }
                        else
                        {
                            if (myArray[i] > myArray[j])
                            {
                                minNextValue = myArray[j];   
                            }   
                        }
                    }

                    currentLen++;
                    countIncreasingArray++;
                    checkSequence[countIncreasingArray] = minNextValue;
                   
                }

            }

            if (currentLen > maxLen)
            {
                maxLen = currentLen;
                maxIncreasingOrder = (int[])checkSequence.Clone();
            }

            currentLen = 0;
            countIncreasingArray = 0;
            for (int i = 0; i < checkSequence.Length; i++)
            {
                checkSequence[i] = 0;
            }

        }

        foreach (var item in maxIncreasingOrder)
        {
            Console.Write("{} ", item);
        }

    }
}

