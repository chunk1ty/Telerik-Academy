namespace PriceFromAllAlbums
{
    using System;
    using System.Xml;
    using System.Xml.Linq;

    class Program
    {
        //Write a program, which extract from the file catalog.xml the prices for all albums, published 5 years ago or earlier. Use XPath query.

        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../../catalogue.xml");

            //string xPathQuery = "/albums/album";
            //XmlNodeList priceList = xmlDoc.SelectNodes(xPathQuery);

            //foreach (XmlNode currentNode in priceList)
            //{
            //    int currentYear = int.Parse(currentNode.SelectSingleNode("year").InnerText);
            //    if (currentYear < 2000)
            //    {
            //        Console.WriteLine(currentNode.SelectSingleNode("price").InnerText);
            //    }
            //}

            //string xPathQuery = "/albums/album[year<2000]";
            //XmlNodeList priceList = xmlDoc.SelectNodes(xPathQuery);

            //foreach (XmlNode currentNode in priceList)
            //{
            //    Console.WriteLine(currentNode.SelectSingleNode("price").InnerText);
            //}
        }
    }
}
