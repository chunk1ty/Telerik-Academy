using System;

class BinaryToDecimal
{
    static void Main()
    {
        string binaryNumber = Console.ReadLine();
        Console.WriteLine(Convert.ToInt64(binaryNumber, 2).ToString());
    }
}
