using System;
using BuildingManager.Contracts;

namespace BuildingManager.ElectricalConsumers
{
    public class Laptop : IElectricalDevice
    {
        private const double MaxCapacity = 100;

        public double ElectricityCapacity
        {
            get;
            private set;
        }

        public void ConsumeElectricity(double electricity)
        {
            ElectricityCapacity = Math.Min(this.ElectricityCapacity + electricity, MaxCapacity);
        }

        public override string ToString()
        {
            return $"Laptop with capacity: {(this.ElectricityCapacity / MaxCapacity) * 100}%";
        }
    }
}
