using BuildingManager.Contracts;

namespace BuildingManager.Adapters
{
    public class Adapter : IElectricalDevice
    {
        private readonly IAmericanElectricalDevice _americanElectricalDevice;

        public Adapter(IAmericanElectricalDevice americanElectricalDevice)
        {
            _americanElectricalDevice = americanElectricalDevice;
        }

        public void ConsumeElectricity(double electricity)
        {
            _americanElectricalDevice.ConsumeAmericanElectricity(electricity);
        }

        public override string ToString()
        {
            return $"Adapter with:\n{_americanElectricalDevice}";
        }
    }
}
