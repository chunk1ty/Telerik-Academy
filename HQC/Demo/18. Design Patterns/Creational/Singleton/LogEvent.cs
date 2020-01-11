using System;

namespace Singleton
{
    public class LogEvent
    {
        public LogEvent(string message)
        {
            Message = message;
            EventDate = DateTime.Now;
        }

        public string Message { get; private set; }

        public DateTime EventDate { get; private set; }
    }
}
