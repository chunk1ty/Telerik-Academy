namespace DayOfWeekService
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel;
    using System.Text;
    using System.Threading.Tasks;

    [ServiceContract]
    public interface IDayOfWeek
    {
        [OperationContract]
        string GetDayOfWeek(DateTime date);
    }
}
