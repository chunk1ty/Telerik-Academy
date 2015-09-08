using System;
using System.Linq;

class CompareTwoCharArrayLexicographically
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        char[] firstArray = new char[size];
        char[] secondArray = new char[size];

        Console.WriteLine("Enter elements of the first array:");
        for (int firstIndex = 0; firstIndex < size; firstIndex++)
        {
            firstArray[firstIndex] = char.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter elements of the second array:");
        for (int secondIntex = 0; secondIntex < size; secondIntex++)
        {
            secondArray[secondIntex] = char.Parse(Console.ReadLine());
        }

        int counter = 0;
        for (int index = 0; index < size; index++)
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
        if (counter == size)
        {
            Console.WriteLine("The arrays are identical!");
        }
        else
        {
            Console.WriteLine("The arrays are different!");
        }    

    }
}

