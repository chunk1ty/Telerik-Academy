using System;

namespace BuildingManager.Common
{
    public abstract class DateTimeProviderAmbientContext 
    {
        private static DateTimeProviderAmbientContext _instance;

        static DateTimeProviderAmbientContext()
        {
            Instance = new DefaultDateTimeProviderAmbientContext();
        }

        public abstract DateTime UtcNow { get; }

        public static DateTimeProviderAmbientContext Instance
        {
            get => _instance;
            set => _instance = value ?? throw new ArgumentNullException(nameof(value));
        }
    }

    public class DefaultDateTimeProviderAmbientContext : DateTimeProviderAmbientContext
    {
        public override DateTime UtcNow => DateTime.UtcNow;
    }
}