using System;

class CalculateWorkdays
{
    static void Main()
    {
        DateTime[] holidays = 
        { 
            new DateTime(2014, 03, 03), 
            new DateTime(2014, 12, 24), 
            new DateTime(2014, 12, 25), 
            new DateTime(2014, 12, 30), 
            new DateTime(2014, 12, 31), 
            new DateTime(2015, 01, 01) 
        };

        DateTime startDate = DateTime.Now.Date;
        Console.WriteLine(startDate);

        Console.WriteLine("Enter a end date in YYYY/MM/DD format");
        string[] endDateStr = Console.ReadLine().Split('/');      

        int year = int.Parse(endDateStr[0]);
        int month = int.Parse(endDateStr[1]);
        int day = int.Parse(endDateStr[2]);
        DateTime endDate = new DateTime(year, month, day);

        //string end = Console.ReadLine();           //same like above (for enter end date)
        //DateTime endDateA = DateTime.Parse(end);

        int timeLen = 0;
        timeLen = (endDate - startDate).Days;
        //Console.WriteLine(timeLen);
        
        int workDay = 0;
        
        for (int i = 0; i < timeLen; i++)
        {            
            bool isHoliday = true;

            if (startDate.DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Sunday)
            {
                for (int j = 0; j < holidays.Length; j++)
                {
                    if (startDate.Date == holidays[j].Date)
                    {
                        isHoliday = false;
                        break;
                    }
                }
                if (isHoliday)
                {
                    workDay++;
                }
            }
            startDate = startDate.AddDays(1);  // add one more day            
        }

        Console.WriteLine(workDay);
        
    }
}

