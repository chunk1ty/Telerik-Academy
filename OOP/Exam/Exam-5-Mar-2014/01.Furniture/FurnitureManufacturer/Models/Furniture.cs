namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    using System;

    public class Furniture : IFurniture
    {
        private string model;
        private MaterialType material;
        private decimal price;
        private decimal height;

        public Furniture(string modelInitial, MaterialType materialInitial, decimal priceInitial, decimal heightInitial)
        {
            this.Model = modelInitial;
            this.material = materialInitial;
            this.Price = priceInitial;
            this.Height = heightInitial;
        }
        public string Model
        {
            get 
            {
                return this.model;          
            }
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Furniture cannot be null or empty!");
                }
                else if (value.Length < 3)
                {
                    throw new ArgumentException("Furniture cannot be less than 3 symbols");
                }
                else
                {
                    this.model = value;
                }   
            }
        }

        public string Material
        {
            get 
            { 
                return this.material.ToString(); 
            }            
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Price cannot be equal to 0.00!");
                }
                else if (value < 0)
                {
                    throw new ArgumentException("Price cannot be less to 0.00!");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public decimal Height
        {
            get
            {
                return this.height;
            }
            protected set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Height cannot be equal to 0.00!");
                }
                else if (value < 0)
                {
                    throw new ArgumentException("Height cannot be less to 0.00!");
                }
                else
                {
                    this.height = value;
                }
                
            }
        }

        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, ", this.GetType().Name, this.Model, this.Material, this.Price, this.Height);
        }
    }
}
