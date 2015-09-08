using System;

class ExchangeIntegerVariables
{
    static void Main()
    {
        int firstInt = 5;
        int secondInt = 10;
        int exchangeValue;
        Console.WriteLine("Values before exchange");
        Console.WriteLine("First value is  : {0}",firstInt);
        Console.WriteLine("Second value is : {0}",secondInt);
        Console.WriteLine(new string('-', 40));

        exchangeValue = firstInt;
        firstInt = secondInt;
        secondInt = exchangeValue;

        Console.WriteLine("Values after exchange");
        Console.WriteLine("First value is  : {0}", firstInt);
        Console.WriteLine("Second value is : {0}", secondInt);
        Console.WriteLine(new string('-', 40));
    }
}

