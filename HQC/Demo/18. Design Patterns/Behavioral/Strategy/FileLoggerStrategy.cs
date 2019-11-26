using System;
using System.IO;

namespace Strategy
{
    /// <summary>
    /// Concrete Strategies implement different variations of an algorithm the context uses.
    /// </summary>
    public class FileLoggerStrategy : ILoggerStrategy
    {
        private readonly string filePath;

        public FileLoggerStrategy(string filePath)
        {
            this.filePath = filePath;
        }

        public void Log(string message)
        {
            Console.WriteLine("Logged into file.");
            File.AppendAllLines(this.filePath, new []{ $"FileLoggerStrategy {message}" });
        }
    }
}
