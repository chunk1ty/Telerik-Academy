using System;
using System.Collections.Generic;

class AddsTwoPositiveInteger
{
    static void Main()
    {
        //not working correctly !!!
        //better solution in another project (MethodsJumpStart)
        List<int> firstNumberInList = new List<int>();
        List<int> secondNumberInList = new List<int>();

        int firstNumber = 1519;//EnterNumber();
        int secondNumber = 8711;//EnterNumber();

        PutDigitInArray(firstNumberInList, firstNumber);
        PutDigitInArray(secondNumberInList, secondNumber);

        if (firstNumberInList.Count > secondNumberInList.Count)
        {
            AddsDigitFromBothList(firstNumberInList, secondNumberInList);
            firstNumberInList.Reverse();
            PrintList(firstNumberInList);
        }
        else
        {
            AddsDigitFromBothList(secondNumberInList, firstNumberInList);
            secondNumberInList.Reverse();
            PrintList(secondNumberInList);
        }       

    }

    private static void PrintList(List<int> firstNumberInList)
    {
        foreach (var item in firstNumberInList)
        {
            Console.Write("{0}", item);
        }
        Console.WriteLine();
    }

    static void AddsDigitFromBothList(List<int> firstList, List<int> secondList)
    {
        int j = 0;
        for (int i = 0; i < firstList.Count; i++)
        {
            if (secondList.Count == j)
            {
                break;
            }
            firstList[i] += secondList[j];

            if (firstList[i] > 10)
            {
                int digit = firstList[i] % 10;
                firstList[i] = firstList[i] / 10;
                int temp = firstList[i];
                firstList[i] = digit;
                firstList[i + 1] += temp;
            }
            j++;
        }
    }

    static void PutDigitInArray(List<int> list, int number)
    {
        while (number != 0)
        {
            int lastDigit = number % 10;
            list.Add(lastDigit);
            number = number / 10;
        }        
    }

    static int EnterNumber()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }    
}

