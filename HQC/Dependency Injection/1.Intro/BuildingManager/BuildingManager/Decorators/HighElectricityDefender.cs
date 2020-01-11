using BuildingManager.Contracts;

namespace BuildingManager.Decorators
{
    // Decorator
    public class HighElectricityDefender : IElectricalDevice
    {
        private const double MaxElectricityAllowed = 100;

        private readonly IElectricalDevice _electricalDevice;

        public HighElectricityDefender(IElectricalDevice electricalDevice)
        {
            _electricalDevice = electricalDevice;
        }

        public void ConsumeElectricity(double electricity)
        {
            if (electricity <= MaxElectricityAllowed)
            {
                _electricalDevice.ConsumeElectricity(electricity);
            }
        }

        public override string ToString()
        {
            return $"Defender with:\n{_electricalDevice}";
        }
    }
}
