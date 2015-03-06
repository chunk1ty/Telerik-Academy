using System;

class FindingThirdBit
{
    static void Main()
    {
        Console.Write("Enter a integer value: ");
        int intValue = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(intValue,2).PadLeft(8,'0'));
        Console.WriteLine((intValue&(1<<3))==0 ? "0" : "1");
        
        
    }
}

