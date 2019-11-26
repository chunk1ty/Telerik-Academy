namespace Strategy
{
    /// <summary>
    /// The Client creates a specific strategy object and passes it to the context. The context exposes a setter which lets clients replace the strategy associated with the context at runtime.
    /// </summary>
    public static class Program
    {
        public static void Main()
        {
            var logger = new FileLoggerStrategy("log.txt");
            //var logger = new ConsoleLoggerStrategy();
            var context = new Context(logger);
            context.ExecuteStrategy("opaaa");
        }
    }
}
