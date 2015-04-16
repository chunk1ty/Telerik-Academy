namespace DeleteAlbums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;

    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../../catalogue.xml");

            var root = xmlDoc.DocumentElement;
            var nodesToDelete = new List<XmlNode>();

            foreach (XmlNode currentNode in root.ChildNodes)
            {
                int currentPrice = int.Parse(currentNode["price"].InnerText);
                if (currentPrice > 20)
                {
                    nodesToDelete.Add(currentNode);
                }
            }

            foreach (var node in nodesToDelete)
            {
                root.RemoveChild(node);
            }

            xmlDoc.Save("../../../deleted.xml");
        }
    }
}
