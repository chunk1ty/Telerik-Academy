using System;

namespace BuildingManager.Common
{
    public static class DateTimeProvider
    {
        private static ITimeService _timeService = new TimeService();

        public static void Initialize(ITimeService dateTimeService)
        {
            _timeService = dateTimeService;
        }

        public static ITimeService Instance => _timeService;
    }

    public interface ITimeService
    {
        DateTime UtcNow { get; }
    }

    public class TimeService : ITimeService
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
