using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        string hexValue = Console.ReadLine();
        int decValue = Convert.ToInt32(hexValue, 16);
        Console.WriteLine(decValue);
    }
}

