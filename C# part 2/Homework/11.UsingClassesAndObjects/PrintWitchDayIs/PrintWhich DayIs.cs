using System;

class PrintWhichDayIs
{
    static void Main()
    {
        DateTime today = DateTime.Now;
        Console.WriteLine(today.DayOfWeek);

        //Console.WriteLine(DateTime.Today.DayOfWeek);
    }
}
