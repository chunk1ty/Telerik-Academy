using System;

class TrapezoidArea
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal h = decimal.Parse(Console.ReadLine());

        Console.WriteLine((a+b)*h/2);
    }
}

