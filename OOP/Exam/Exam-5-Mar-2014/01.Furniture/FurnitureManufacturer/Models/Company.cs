namespace FurnitureManufacturer.Models
{
    using System;
    using FurnitureManufacturer.Interfaces;
    using System.Collections.Generic;
    using System.Collections;
    using System.Linq;
    using System.Text;

    public class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;
        public Company(string nameInitial, string registrationNumberInitial)
        {
            this.Name = nameInitial;
            this.RegistrationNumber = registrationNumberInitial;
            this.furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get 
            {
                return this.name;    
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Company name cannot be null or empty!");
                }
                if (value.Length < 5)
                {
                    throw new ArgumentOutOfRangeException("Company name cannot be less than 5 symbols!");
                }
                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get 
            {
                return this.registrationNumber;    
            }
            private set
            {
                if (value.Length != 10)
                {
                    throw new ArgumentOutOfRangeException("Registration number must be exactly 10 symbols!");
                }
                foreach (var digit in value)
                {
                    if (char.IsDigit(digit))
                    {
                        continue;
                    }
                    else
                    {
                        throw new ArgumentException("Registration number must contain only digits!");
                    }
                }
                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get 
            {
                return new List<IFurniture>(this.furnitures);
            }
        }

        public void Add(IFurniture furniture)
        {
           this.furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            return this.furnitures.FirstOrDefault(f => f.Model.ToLower() == model.ToLower());
        }

        public string Catalog()
        {
            string result = string.Format("{0} - {1} - {2} {3}", this.Name, this.RegistrationNumber, this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no", this.Furnitures.Count != 1 ? "furnitures" : "furniture");

            var sb = new StringBuilder();
            sb.AppendLine(result);

            var sortedFurnitures = this.Furnitures.OrderBy(x => x.Price).ThenBy(x => x.Model);

            if (this.Furnitures.Count != 0)
            {
                foreach (var item in sortedFurnitures)
                {                    
                    sb.AppendLine(item.ToString());
                }

                return sb.ToString().Trim(); ;
            }
            else
            {
                return result;
            }
        }
    }
}
