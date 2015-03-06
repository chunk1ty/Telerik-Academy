using System;
using System.Linq;

class CompareTwoArrays
{
    static void Main()
    {
        Console.Write("How much long u want to be this two arrays.");
        int n = int.Parse(Console.ReadLine());

        int[] firstArray = new int[n];
        int[] secondArray = new int[n];

        Console.WriteLine("Enter elements of the first array:");
        for (int firstIndex = 0; firstIndex < n; firstIndex++)
        {
            firstArray[firstIndex] = int.Parse(Console.ReadLine());   
        }
        Console.WriteLine("Enter elements of the second array:");
        for (int secondIntex = 0; secondIntex < n; secondIntex++)
        {
            secondArray[secondIntex] = int.Parse(Console.ReadLine());
        }

        int counter = 0;
        
        for (int index = 0; index < n; index++)
        {
            if (firstArray[index] == secondArray[index])
            {
                counter++;
            }
            else
            {
                continue;
            }
        }

        if (counter==n)
        {
            Console.WriteLine("The arrays are identical!");
        }
        else
        {
            Console.WriteLine("The arrays are different!");
        }    
    }
}

