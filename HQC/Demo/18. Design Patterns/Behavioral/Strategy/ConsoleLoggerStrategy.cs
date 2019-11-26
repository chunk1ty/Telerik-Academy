using System;

namespace Strategy
{
    /// <summary>
    /// Concrete Strategies implement different variations of an algorithm the context uses.
    /// </summary>
    public class ConsoleLoggerStrategy : ILoggerStrategy
    {
        public void Log(string message)
        {
            Console.WriteLine($"ConsoleLoggerStrategy {message}");
        }
    }
}
