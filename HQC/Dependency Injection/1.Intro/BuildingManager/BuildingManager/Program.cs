using System;
using System.Collections.Generic;
using BuildingManager.Adapters;
using BuildingManager.Contracts;
using BuildingManager.Decorators;
using BuildingManager.ElectricalConsumers;

namespace BuildingManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var laptop = new Laptop();

            var americanLaptop = new AmericanLaptop();
            var adaptedAmericanLaptop = new Adapter(americanLaptop);

            var electricalDevices = new List<IElectricalDevice> { laptop, adaptedAmericanLaptop };

            var powerStrip = new PowerStrip(electricalDevices);

            var ups = new Ups(powerStrip);
            var defender = new HighElectricityDefender(ups);

            defender.ConsumeElectricity(20);

            Console.WriteLine(defender.ToString());
        }
    }
}
