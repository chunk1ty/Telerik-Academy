using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Wintellect.PowerCollections;

namespace OnlineMarket
{
    class Program
    {
        static Dictionary<string, Product> product = new Dictionary<string, Product>();
        static StringBuilder sb = new StringBuilder();

        static void Main(string[] args)
        {
            string[] currentLine = Console.ReadLine().Split(' ');

            while (currentLine[0] != "end")
            {
                var command = currentLine[0];
                if (command == "add")
                {
                    AddProductToMArket(currentLine);

                }
                else if (command == "filter")
                {
                    string cmd = currentLine[2];
                    if (cmd == "type")
                    {
                        FilterByType(currentLine);
                    }
                    else if (cmd == "price")
                    {
                        string fromOrTo = currentLine[3];

                        if (fromOrTo == "from")
                        {
                            double minPrice = double.Parse(currentLine[4], CultureInfo.InvariantCulture);

                            if (currentLine.Length > 5)
                            {

                            }
                            else
                            {
                                sb.Append("Ok: ");
                                int counter = 0;

                                string prefix = "";
                                foreach (var item in product)
                                {
                                    var currentPrice = item.Value.Price;
                                    if (minPrice < currentPrice)
                                    {
                                        sb.Append(prefix);
                                        prefix = ", ";
                                        sb.AppendFormat("{0}({1})", item.Key, item.Value.Price);
                                        counter++;
                                    }

                                    if (counter >= 10)
                                    {
                                        break;
                                    }
                                }
                                sb.AppendLine();
                            }
                        }
                        else if (fromOrTo == "to")
                        {
                            double maxPrice = double.Parse(currentLine[4], CultureInfo.InvariantCulture);

                            sb.Append("Ok: ");
                            int counter = 0;

                            string prefix = "";
                            foreach (var item in product)
                            {
                                var currentPrice = item.Value.Price;
                                if (maxPrice > currentPrice)
                                {
                                    sb.Append(prefix);
                                    prefix = ", ";
                                    sb.AppendFormat("{0}({1})", item.Key, item.Value.Price);
                                    counter++;
                                }

                                if (counter >= 10)
                                {
                                    break;
                                }
                            }
                            sb.AppendLine();

                        }
                    }
                }

                currentLine = Console.ReadLine().Split(' ');
            }

            Console.WriteLine(sb.ToString());
        }

        private static void FilterByType(string[] currentLine)
        {
            string productType = currentLine[3];
            sb.Append("Ok: ");
            int counter = 0;
            bool isMatch = false;

            string prefix = "";
            foreach (var item in product)
            {
                var currentType = item.Value.Type;
                if (currentType == productType)
                {
                    isMatch = true;
                    sb.Append(prefix);
                    prefix = ", ";
                    sb.AppendFormat("{0}({1})", item.Key, item.Value.Price);
                    counter++;
                }
                //if (item.Value.Item2 == productType && counter < 10)
                //{
                //    isMatch = true;
                //    sb.Append(prefix);
                //    prefix = ", ";
                //    sb.AppendFormat("{0}({1})", item.Key, item.Value.Item1);
                //    counter++;
                //}
                if (counter >= 10)
                {
                    break;
                }
            }

            if (!isMatch)
            {
                sb.AppendFormat("Error: Type {0} does not exists", productType);
            }

            sb.AppendLine();
        }

        private static void AddProductToMArket(string[] currentLine)
        {
            string productName = currentLine[1];
            double productPrice = double.Parse(currentLine[2], CultureInfo.InvariantCulture);
            string productType = currentLine[3];
            if (!product.ContainsKey(productName))
            {
                var currentPriceAndType = new Product(productPrice, productType);
                product.Add(productName, currentPriceAndType);

                sb.AppendFormat("Ok: Product {0} added successfully", productName);
                sb.AppendLine();
            }
            else
            {
                sb.AppendFormat("Error: Product {0} already exists", productName);
                sb.AppendLine();
            }
        }

        public class Product
        {
            public double Price { get; set; }
            public string Type { get; set; }

            public Product(double price, string type)
            {
                this.Price = price;
                this.Type = type;
            }
        }

    }
}
