using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        int decimalNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(decimalNumber, 16));
    }
}

