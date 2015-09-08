using System;

class PrintAge
{
    static void Main()
    {
        Console.Write("Enter your age : ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Your age after 10 years : {0}",age+10);
    }
}

