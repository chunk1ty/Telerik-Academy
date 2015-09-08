using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace DayOfWeekService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DayOfWeekk" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DayOfWeekk.svc or DayOfWeekk.svc.cs at the Solution Explorer and start debugging.
    public class DayOfWeekk : IDayOfWeek
    {
        public string GetDayOfWeek(DateTime date)
        {
            switch (date.DayOfWeek)
            {
                case DayOfWeek.Friday: return "Петък";
                case DayOfWeek.Monday: return "Понеделник";
                case DayOfWeek.Saturday: return "Събота";
                case DayOfWeek.Sunday: return "Неделя";
                case DayOfWeek.Thursday: return "Четвъртък";
                case DayOfWeek.Tuesday: return "Вторник";
                case DayOfWeek.Wednesday: return "Сряда";
                default: return null;
            }
            //var bulgarianCulture = new CultureInfo("bg-BG");
            //Thread.CurrentThread.CurrentCulture = bulgarianCulture;

            //var dayOfWeek = date.DayOfWeek;

            //var dayOfWeekAsString = CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(dayOfWeek);
            //return dayOfWeekAsString;
        }
    }
}
