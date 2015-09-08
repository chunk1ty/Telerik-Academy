using System;

class SubSetSum
{
    static void Main()
    {
        //int[] myArray = { 2, 1, 2, 4, 3, 5, 2, 6 };
        int[] myArray = { 17, 34, 2, 4, 1 };
        int[] posibleNumberArray = new int[myArray.Length];
        int sum = 21;
        int currentSum = 0;
        int k = 0;

        for (int index = 0; index < myArray.Length-1; index++)
        {
            currentSum += myArray[index];
            posibleNumberArray[k] = myArray[index];

            for (int j = index+1; j < myArray.Length; j++)
            {
                if (myArray[j] < sum)
                {
                    k++;
                    currentSum += myArray[j];
                    posibleNumberArray[k] = myArray[j];   
                }
                if (currentSum > sum)
                { 
                    currentSum -= myArray[j];
                    posibleNumberArray[k] = 0;
                    k--;
                }
                if (currentSum == sum)
                {
                    break;
                } 
            }

            if (currentSum == sum)
            {
                break;
            }
            currentSum = 0;
            k = 0;
            for (k = 0; k < posibleNumberArray.Length; k++)
            {
                 posibleNumberArray[k] = 0; 
            }
            k = 0;
        }

        if (currentSum == sum)
        {
            for (int i = 0; i < posibleNumberArray.Length; i++)
            {
                if (posibleNumberArray[i] != 0)
                {
                    Console.Write("{0} ", posibleNumberArray[i]);
                }
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("The sum is not exist!");
        }
    }
}
