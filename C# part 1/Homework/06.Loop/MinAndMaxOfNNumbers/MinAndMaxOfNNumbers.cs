using System;
using System.Linq;

class MinAndMaxOfNNumbers
{
    static void Main()
    {
        ////First solution with array
        //Console.Write("How many elements you want to enter: ");
        //int length = int.Parse(Console.ReadLine());
        //int[] array = new int[length];
        //int maxValue;
        //int minVAlue;

        //for (int i = 0; i < length; i++)
        //{
        //    Console.Write("Enter element number {0} :",i+1);
        //    array[i] = int.Parse(Console.ReadLine());
        //}

        //maxValue = array.Max();
        //minVAlue = array.Min();
        //Console.WriteLine("Max number is " + maxValue);
        //Console.WriteLine("Min number is " + minVAlue);

        //Second Solution
        int length = int.Parse(Console.ReadLine());
        int inputNumber;
        int max = int.MinValue;
        int min = int.MaxValue;
        //Console.WriteLine(max);
        //Console.WriteLine(min);
        for (int i = 0; i < length; i++)
        {
            inputNumber = int.Parse(Console.ReadLine());
            if (max < inputNumber)
            {
                max = inputNumber;
            }
            if (min > inputNumber)
            {
                min = inputNumber;
            } 
        }

        Console.WriteLine("Min is :"+min);
        Console.WriteLine("Max is :"+max);

    }
}
