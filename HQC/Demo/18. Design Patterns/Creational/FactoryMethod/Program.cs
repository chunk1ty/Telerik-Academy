using System;
using System.Configuration;

using FactoryMethod.Manufacturers;

namespace FactoryMethod
{
    public static class Program
    {
        public static void Main()
        {
            var factory = ConfigurationManager.AppSettings["ManufacturerFactory"];

            Manufacturer manufacturer;
            switch (factory)
            {
                case "Xiaomi":
                    manufacturer = new XiaomiFactory();
                    break;
                case "Samsung":
                    manufacturer = new SamsungFactory();
                    break;
                default:
                    throw new Exception("Factory not found");
            }

            var phone = manufacturer.ManufactureGsm();
            Console.WriteLine(phone.ToString());
            phone.Start();
        }
    }
}
