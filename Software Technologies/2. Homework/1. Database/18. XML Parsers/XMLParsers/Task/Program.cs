namespace Task
{
    using System;
    using System.Collections.Generic;    
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;

    public class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../catalogue.xml");

            //CountingArtistsAlbums(xmlDoc);
            ContingArtistAlbumsWithXpath(xmlDoc);
        }

        private static void ContingArtistAlbumsWithXpath(XmlDocument xmlDoc)
        {
            string xPathQuery = "/albums/album/artist";

            XmlNodeList artirsList = xmlDoc.SelectNodes(xPathQuery);
            var artists = new Dictionary<string, int>();

            foreach (XmlNode artist in artirsList)
            {
                string artirstName = artist.InnerText;

                if (artists.ContainsKey(artirstName))
                {
                    artists[artirstName] += 1;
                }
                else
                {
                    artists[artirstName] = 1;
                }
            }

            foreach (var artist in artists)
            {
                Console.WriteLine("Artist {0} -> albums {1}", artist.Key, artist.Value);
            }
        }

        private static void CountingArtistsAlbums(XmlDocument xmlDoc)
        {
            var root = xmlDoc.DocumentElement;

            var artists = new Dictionary<string, int>();
            foreach (XmlNode node in root.ChildNodes)
            {
                var artistName = node["artist"].InnerText;

                if (artists.ContainsKey(artistName))
                {
                    artists[artistName] += 1;
                }
                else
                {
                    artists[artistName] = 1;
                }
            }

            foreach (var artist in artists)
            {
                Console.WriteLine("Artist {0} -> albums {1}", artist.Key, artist.Value);
            }
        }
    }
}
