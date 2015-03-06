using System;

class IsLeapYear
{
    static void Main()
    {
        Console.WriteLine("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        bool isLeap = DateTime.IsLeapYear(year);

        if (isLeap)
        {
            Console.WriteLine("Leap year!");
        }
        else
        {
            Console.WriteLine("Not leap year!");
        }
    }
}

