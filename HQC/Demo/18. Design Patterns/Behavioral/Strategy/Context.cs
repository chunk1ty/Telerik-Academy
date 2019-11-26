namespace Strategy
{
    /// <summary>
    /// The Context maintains a reference to one of the concrete strategies and communicates with this object only via the strategy interface.
    /// </summary>
    public class Context
    {
        private readonly ILoggerStrategy _loggerStrategy;

        public Context(ILoggerStrategy loggerStrategy)
        {
            _loggerStrategy = loggerStrategy;
        }

        public void ExecuteStrategy(string message)
        {
            _loggerStrategy.Log(message);
        }
    }
}
