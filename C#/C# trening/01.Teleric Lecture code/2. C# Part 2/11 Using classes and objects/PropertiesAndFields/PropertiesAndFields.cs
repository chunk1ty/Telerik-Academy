using System;

class PropertiesAndFields
{
    static void Main()
    {
        DateTime christmas = new DateTime(2011, 12, 25);

        int day = christmas.Day;
        int month = christmas.Month;
        int year = christmas.Year;
        Console.WriteLine(
            "Christmas day: {0}, month: {1}, year: {2}", day, month, year);

        Console.WriteLine("Day of year: {0}", christmas.DayOfYear);

        Console.WriteLine(
            "Is {0} leap year: {1}", year, DateTime.IsLeapYear(year));
    }
}
