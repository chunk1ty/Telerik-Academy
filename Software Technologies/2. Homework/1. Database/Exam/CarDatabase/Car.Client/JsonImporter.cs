namespace Car.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    using Newtonsoft.Json.Linq;

    using Car.Data;
    using System.IO;
    using System.Text.RegularExpressions;
    using Car.Models;

    public class JsonImporter
    {
        private CarContext context;

        public JsonImporter(CarContext db)
        {
            this.context = db;
        }

        public void ImportDirectory(string directoryPath)
        {
            var pattern = @"data\.\d+\.json";
            var jsonFiles = Directory.GetFiles(directoryPath).Where(path => Regex.Match(path, pattern).Success);

            this.context.Configuration.AutoDetectChangesEnabled = false;

            foreach (var jsonFile in jsonFiles)
            { 
                this.ImportFile(jsonFile);
            }

            this.context.Configuration.AutoDetectChangesEnabled = true;            
        }

        public void ImportFile(string jsonFilePath)
        {
            var jsonString = File.ReadAllText(jsonFilePath);

            var jsonCarsArray = JArray.Parse(jsonString);

            foreach (var jsonCar in jsonCarsArray)
            {
                var car = new CarClass()
                {
                    Year = int.Parse(jsonCar["Year"].ToString()),
                    TransmissionType = GetTransmisionType(jsonCar["TransmissionType"].ToString()),
                    Manufacturer = GetManufacturer(jsonCar["ManufacturerName"].ToString()),
                    Model = jsonCar["Model"].ToString(),
                    Price = decimal.Parse(jsonCar["Price"].ToString()),
                    Dealer = GetDealer(jsonCar["Dealer"]["Name"].ToString(), jsonCar["Dealer"]["City"].ToString())
                };

                this.context.Cars.Add(car);
                this.context.SaveChanges();
            }
        }

        private Manufacturer GetManufacturer(string manufacturerName)
        {
            var manufacturer = this.context.Manufacturers.FirstOrDefault(m => m.Name == manufacturerName);

            if (manufacturer == null)
            {
                manufacturer = new Manufacturer()
                {
                    Name = manufacturerName
                };
            }

            return manufacturer;
        }

        private City GetCity(string cityName)
        {
            var city = this.context.Cities.FirstOrDefault(c => c.Name == cityName);

            if (city == null)
            {
                city = new City()
                {
                    Name = cityName
                };
            }

            return city;
        }

        private Dealer GetDealer(string dealerName, string cityName)
        {
            var dealer = this.context.Dealers.FirstOrDefault(d => d.Name == dealerName);

            if (dealer == null)
            {
                dealer = new Dealer()
                {
                    Name = dealerName
                };
            }

            // add city to this dealer if it is not present
            if (!dealer.Cities.Any(c => c.Name == cityName))
            {
                dealer.Cities.Add(GetCity(cityName));
            }

            return dealer;
        }

        private TransmissionType GetTransmisionType(string transmissionTypeIndex)
        {
            var transmissionTypeIndexAsInt = int.Parse(transmissionTypeIndex);
            return (TransmissionType)transmissionTypeIndexAsInt;
        }
    }
}
