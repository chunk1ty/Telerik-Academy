using System;

class EvenOrOdd
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int intNumber = int.Parse(Console.ReadLine());
        Console.WriteLine((intNumber%2==0)?"Even": "Odd" );
    }
}

