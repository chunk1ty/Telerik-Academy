namespace LargeCollection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Product : IComparable<Product>
    {
        public int Price { get; set; }
        public string Name { get; set; }

        public Product(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        public int CompareTo(Product other)
        {
            return this.Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return string.Format("Name: {0} Price: {1:C}", this.Name, this.Price);
        }
    }
}
