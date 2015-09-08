using System;

class CheckPositionPinNumberV
{
    static void Main()
    {
        Console.Write("Enter a integer value: ");
        int intValue = int.Parse(Console.ReadLine());
        Console.Write("Enter position: ");
        int intPosition = int.Parse(Console.ReadLine());

        Console.WriteLine(Convert.ToString(intValue, 2).PadLeft(8, '0'));
        Console.WriteLine(Convert.ToString( 1<<intPosition , 2).PadLeft(8, '0'));
        Console.WriteLine(new string ('-',40));

        int mask = 1 << intPosition;
        int result = mask & intValue;
        result = result >> intPosition;

        Console.WriteLine(result);                               //11
        Console.WriteLine(result == 1 ? true : false);           //10
    }
}

