
namespace LargeCollection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Wintellect.PowerCollections;

    class Program
    {
        static void Main(string[] args)
        {
            Random randomGen = new Random();
            OrderedBag<Product> bag = new OrderedBag<Product>();

            for (int i = 0; i < 500000; i++)
            {
                bag.Add(new Product("Product Number" + i, randomGen.Next(0, int.MaxValue)));
            }

            List<Product> first20 = new List<Product>();
            bool isAll = false;

            for (int i = 0; i < 10000; i++)
            {
                var firstTwenty = bag.Range(new Product(string.Empty, int.MinValue), true, new Product(string.Empty, int.MaxValue), true);
                Console.WriteLine(firstTwenty.Count);
                for (int j = 0; j < firstTwenty.Count; j++)
                {
                    Console.WriteLine(firstTwenty.Count);
                    first20.Add(firstTwenty[j]);

                    if (first20.Count == 20)
                    {
                        isAll = true;
                        break;
                    }
                }

                if (isAll)
                {
                    break;
                }
            }

            for (int i = 0; i < first20.Count; i++)
            {
                Console.WriteLine(first20[i]);
            }
        }
    }
}
