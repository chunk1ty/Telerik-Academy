namespace TradeCompanyTask
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
            var articles = new OrderedMultiDictionary<int, Article>(true);
            Random random = new Random();            

            for (int i = 0; i < 100; i++)
            {
                var currentArticle = new Article(random.Next(1,20000),"Vendor" + i,"Title" + i, random.Next(1,200));
                int currentPrice = currentArticle.Price;

                if (!articles.ContainsKey(currentPrice))
                {
                    articles.Add(currentPrice, currentArticle);
                }               
            }

            var range = articles.Range(0 , true, 17, true);

            //Console.WriteLine(range.Count);
            //Console.WriteLine(string.Join(Environment.NewLine, range.Select(i => string.Join(", ", i.Value))));

            foreach (var item in range)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
