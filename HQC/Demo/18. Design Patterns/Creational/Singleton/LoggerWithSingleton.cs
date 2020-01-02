using System;
using System.Collections.Generic;

namespace Singleton
{
    // Do not use! Not thread-safe.
    /// <summary>
    /// The Singleton class declares the static method getInstance that returns the same instance of its own class
    /// </summary>
    public sealed class Logger
    {
        private static Logger _loggerInstance;

        private readonly List<LogEvent> events = new List<LogEvent>();

        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                if (_loggerInstance == null)
                {
                    _loggerInstance = new Logger();
                }

                return _loggerInstance;
            }
        }

        public void SaveToLog(string message)
        {
            events.Add(new LogEvent(message));
        }

        public void PrintLog()
        {
            foreach (var ev in events)
            {
                Console.WriteLine("Time: {0}, Event: {1}", ev.EventDate.ToShortTimeString(), ev.Message);
            }
        }
    }
}
