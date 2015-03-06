using System;
using System.Linq;


class ReverseNumber
{
    static void Main()
    {
        decimal someNumber = decimal.Parse(Console.ReadLine());
        Console.WriteLine(ReverseDecimalNumber(someNumber));
    }

    static decimal ReverseDecimalNumber(decimal number)
    {
        string decAsString = number.ToString();

        char[] array = decAsString.ToCharArray();
        char[] reverseArray = new char[array.Length];

        int len = array.Length;
        
        for (int i = 0; i < len; i++)
        {
            reverseArray[i] = array[len - 1 - i];
        }

        decAsString = new string(reverseArray);

        decimal reverseNumber = decimal.Parse(decAsString);
        return reverseNumber;        
    }
}

