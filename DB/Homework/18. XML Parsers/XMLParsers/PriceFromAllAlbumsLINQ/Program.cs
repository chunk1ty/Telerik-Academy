using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PriceFromAllAlbumsLINQ
{
    //Write a program, which extract from the file catalog.xml the prices for all albums, published 5 years ago or earlier. Use LINQ.

    class Program
    {
        static void Main(string[] args)
        {
            XDocument xmlDoc = XDocument.Load("../../../catalogue.xml");

            var prices =
                from album in xmlDoc.Descendants("album")
                where int.Parse(album.Element("year").Value) < 2000
                select new
                {
                    Price = album.Element("price").Value
                };

            foreach (var price in prices)
            {
                Console.WriteLine(price.Price);
            }
        }
    }
}
