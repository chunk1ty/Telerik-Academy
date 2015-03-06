using System;
using System.Collections.Generic;

class SortArrayOfString
{
    static void SortArrayOfStringFunction(string[] myArray)
    {
        for (int i = 0; i < myArray.Length - 1; i++)
        {           
            int length = myArray[i].Length;

            for (int j = i + 1; j < myArray.Length; j++)
            {               
                int nextLength =myArray[j].Length;

                if (length > nextLength)
                {
                    string temp = myArray[i];
                    myArray[i] = myArray[j];
                    myArray[j] = temp;
                    length = myArray[i].Length;
                }
            }
        }

        foreach (var item in myArray)
        {
            Console.Write("{0} ",item);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        string[] arrayOfStrings = { "ank", "Andriyan", "Nevelinov", "Cska", "levski", "AstonVila", "aa", "FC" };
        //Array.Sort(arrayOfStrings);

        //foreach (var item in arrayOfStrings)
        //{
        //    Console.Write("{0} ",item);
        //}
        SortArrayOfStringFunction(arrayOfStrings);
    }
}

