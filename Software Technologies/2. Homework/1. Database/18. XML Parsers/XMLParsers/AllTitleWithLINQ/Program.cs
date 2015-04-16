using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AllTitleWithLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument doc = XDocument.Load("../../../catalogue.xml");
            var titles =
                from song in doc.Descendants("song")
                select new
                {
                    SongTitle = song.Element("title").Value
                };

            foreach (var title in titles)
            {
                Console.WriteLine(title.SongTitle);
            }
        }
    }
}
