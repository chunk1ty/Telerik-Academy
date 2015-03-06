using System;
//using System.Collections.Generic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

class MinMaxAndAvarage
{
    static void Main()
    {
        int[] myArray = { 2, 7, 1, 5, 4, 1, 5, 3, 6, 2 };

        Console.Write("Min {0} Max {1} Average {2}", myArray.Min(), myArray.Max(), myArray.Average());
        Console.WriteLine();

        int minValue = int.MaxValue;
        int maxValue = int.MinValue;
        double sum = 0;

        for (int i = 0; i < myArray.Length; i++)
        {
            if (maxValue < myArray[i])
            {
                maxValue = myArray[i];
            }
            if (minValue > myArray[i])
            {
                minValue = myArray[i];
            }
            sum += myArray[i];
        }

        double average = sum / myArray.Length;

        Console.Write("Min {0} Max {1} Average {2}", minValue, maxValue, average);
        Console.WriteLine();
    }
}

