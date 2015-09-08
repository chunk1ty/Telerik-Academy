using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace test
{
    class Program
    {
        static void Main()
        {
            SgmlReader reader = new SgmlReader();
            using (reader)
            {
                reader.DocType = "HTML";
                reader.Href = "http://www.example.com";
                var doc = new XmlDocument();
                doc.Load(reader);              
                var anchors = doc.SelectNodes("//a/@href[contains(., 'mp3') or contains(., 'wav')]");
                foreach (XmlAttribute href in anchors)
                {
                    using (var client = new WebClient())
                    {
                        var data = client.DownloadData(href.Value);
                        // TODO: do something with the downloaded data
                    }
                }
            }
        }
    }
}
