using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlWriterAndReader
{
    //Write a program, which (using XmlReader and XmlWriter) reads the file catalog.xml and creates the file album.xml, in which stores in appropriate way the names of all albums and their authors.

    class Program
    {
        static void Main(string[] args)
        {

            string fileName = "../../../albums.xml";
            Encoding encoding = Encoding.GetEncoding("windows-1251");

            using (XmlTextWriter writer = new XmlTextWriter(fileName, encoding))
            {                
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 1;
                // kak da se formirat na vutre v tozi sluchai s 1 tab
                writer.IndentChar = '\t';

                writer.WriteStartElement("albums");
                using (XmlReader reader = XmlReader.Create("../../../catalogue.xml"))
                {
                    while (reader.Read())
                    {
                        if ((reader.Name == "name") && (reader.NodeType == XmlNodeType.Element))
                        {
                            WriteTitle(writer, reader.ReadInnerXml());
                        }
                        else if ((reader.Name == "artist") && (reader.NodeType == XmlNodeType.Element))
                        {
                            WriteArtist(writer, reader.ReadInnerXml());
                        }
                    }
                }
                writer.WriteEndElement();
            }
        }

        private static void WriteTitle(XmlWriter writer, string title)
        {
            writer.WriteStartElement("album");
            writer.WriteElementString("name", title);            
        }

        private static void WriteArtist(XmlWriter writer, string artist)
        {            
            writer.WriteElementString("artist", artist);
            writer.WriteEndElement();
        }
    }
}
