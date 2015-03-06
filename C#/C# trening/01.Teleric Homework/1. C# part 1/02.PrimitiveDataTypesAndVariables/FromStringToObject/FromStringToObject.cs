using System;

class FromStringToObject
{
    static void Main()
    {
        string firstSring = "Hello";
        string secondString = "World";
        object result = firstSring + " " + secondString;
        string stringResult = (string)result;
        Console.WriteLine(stringResult);

    }
}

