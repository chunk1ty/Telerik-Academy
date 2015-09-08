using System;

class PrintName
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = PrintFirstName();
        Console.WriteLine("Hello, {0} !",name);
    }

    static string PrintFirstName()
    {
        string name = Console.ReadLine();
        return name;
    }
}

