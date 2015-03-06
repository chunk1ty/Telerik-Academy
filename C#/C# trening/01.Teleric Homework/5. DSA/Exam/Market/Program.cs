namespace Market
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Text;
    using System.Threading.Tasks;
    using Wintellect.PowerCollections;

    class Program
    {
        static StringBuilder sb = new StringBuilder();
        static OrderedBag<Product> bag = new OrderedBag<Product>();

        static void Main(string[] args)
        {
            string[] currentLine = Console.ReadLine().Split(' ');

            while (currentLine[0] != "end")
            {
                var command = currentLine[0];
                if (command == "add")
                {
                    AddProductToBag(currentLine);
                }
                else if (command == "filter")
                {
                    var types = currentLine[2];

                    if (types == "type")
                    {
                        string type = currentLine[3];
                       
                        int count = 0;
                        sb.Append("Ok: ");
                        string prefix = "";
                        bool isMatch = false;
                        foreach (var product in bag)
                        {
                            if (count < 10 && product.Type == type)
                            {
                                sb.Append(prefix);
                                prefix = ", ";
                                sb.AppendFormat("{0}({1})", product.Name, product.Price);
                                count++;
                                isMatch = true;
                            }
                            if (count >= 10)
                            {
                                break;
                            }
                        }

                        if (!isMatch)
                        {
                            sb.Remove(0, 3);
                            sb.AppendFormat("Error: Type {0} does not exists", type);
                            isMatch = false;
                        }
                       
                        sb.AppendLine();
                    }
                    else
                    {
                        var fromOrTo = currentLine[3];
                        if (fromOrTo == "to")
                        {
                            FilterByMaxPrice(currentLine);
                        }
                        else if (fromOrTo == "from")
                        {
                            if (currentLine.Length > 5)
                            {
                                var minPrice = double.Parse(currentLine[4], CultureInfo.InvariantCulture);
                                var maxPrice = double.Parse(currentLine[6], CultureInfo.InvariantCulture);

                                var firstTen = bag.Range(new Product(string.Empty, minPrice, string.Empty), true, new Product(string.Empty, maxPrice, string.Empty), true);

                                sb.Append("Ok: ");
                                string prefix = "";
                                for (int i = 0; i < firstTen.Count; i++)
                                {
                                    sb.Append(prefix);
                                    prefix = ", ";
                                    sb.AppendFormat("{0}({1})", firstTen[i].Name, firstTen[i].Price);
                                }

                                sb.AppendLine();
                            }
                            else
                            {
                                FilterByMinPrice(currentLine);
                            }
                        }
                    }

                }

                currentLine = Console.ReadLine().Split(' ');
            }

            Console.WriteLine(sb.ToString());
        }

        private static void FilterByMinPrice(string[] currentLine)
        {
            double minPrice = double.Parse(currentLine[4], CultureInfo.InvariantCulture);

            int count = 0;
            sb.Append("Ok: ");
            string prefix = "";
            foreach (var product in bag)
            {
                if (minPrice < product.Price && count < 10)
                {
                    sb.Append(prefix);
                    prefix = ", ";
                    sb.AppendFormat("{0}({1})", product.Name, product.Price);
                    count++;
                }
                if (count >= 10)
                {
                    break;
                }
            }
            sb.AppendLine();
        }

        private static void FilterByMaxPrice(string[] currentLine)
        {
            double maxPrice = double.Parse(currentLine[4], CultureInfo.InvariantCulture);

            sb.Append("Ok: ");
            string prefix = "";
            foreach (var product in bag)
            {
                if (maxPrice > product.Price)
                {
                    sb.Append(prefix);
                    prefix = ", ";
                    sb.AppendFormat("{0}({1})", product.Name, product.Price);
                }
            }

            sb.AppendLine();
        }

        private static void AddProductToBag(string[] currentLine)
        {
            string productName = currentLine[1];
            double productPrice = double.Parse(currentLine[2], CultureInfo.InvariantCulture);
            string productType = currentLine[3];
            var currentProduct = new Product(productName, productPrice, productType);

            if (!bag.Contains(currentProduct))
            {
                bag.Add(currentProduct);

                sb.AppendFormat("Ok: Product {0} added successfully", productName);
                sb.AppendLine();
            }
            else
            {
                sb.AppendFormat("Error: Product {0} already exists", productName);
                sb.AppendLine();
            }
        }


    }

    public class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }

        public Product(string name, double price, string type)
        {
            this.Name = name;
            this.Price = price;
            this.Type = type;
        }

        public int CompareTo(Product other)
        {
            if (this.Price == other.Price)
            {
                if (this.Name == other.Name)
                {
                    return this.Type.CompareTo(other.Type);
                }

                return this.Name.CompareTo(other.Name);
            }

            return this.Price.CompareTo(other.Price);
        }
    }
}
