using System;
using BuildingManager.Contracts;

namespace BuildingManager.ElectricalConsumers
{
    public class AmericanLaptop : IAmericanElectricalDevice
    {
        private const double MaxCapacity = 200;

        public double ElectricityCapacity
        {
            get;
            private set;
        }

        public void ConsumeAmericanElectricity(double electricity)
        {
            ElectricityCapacity = Math.Min(ElectricityCapacity + electricity, MaxCapacity);
        }

        public override string ToString()
        {
            return $"American laptop with capacity: {(ElectricityCapacity / MaxCapacity) * 100}%";
        }
    }
}
