namespace Strategy
{
    /// <summary>
    /// The Strategy interface is common to all concrete strategies. It declares a method the context uses to execute a strategy.
    /// </summary>
    public interface ILoggerStrategy
    {
        void Log(string message);
    }
}
