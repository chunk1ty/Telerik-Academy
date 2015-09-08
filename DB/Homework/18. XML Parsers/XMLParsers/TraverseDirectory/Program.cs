using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TraverseDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            TraverseDir(@"D:\Chunk1tySVN", @"..\..\..\my-directory.xml");
        }
        
        private static void TraverseDir(string directoryPath, string xmlResultPath)
        {
            using (XmlTextWriter writer = new XmlTextWriter(xmlResultPath, Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                //declaration ?xml version ...
                writer.WriteStartDocument();
                writer.WriteStartElement("root-directory");
                writer.WriteAttributeString("path", directoryPath);

                DFS(writer, directoryPath);

                writer.WriteEndDocument();
            }            
        }

        private static void DFS(XmlTextWriter writer, string directoryPath)
        {
            foreach (var directory in Directory.GetDirectories(directoryPath))
            {
                writer.WriteStartElement("dir");
                writer.WriteAttributeString("name", directory);

                DFS(writer, directory);

                writer.WriteEndElement();
            }

            foreach (var file in Directory.GetFiles(directoryPath))
            {
                writer.WriteStartElement("file");
                writer.WriteAttributeString("name", file);
                writer.WriteAttributeString("size", new FileInfo(file).Length.ToString());
                writer.WriteEndElement();
            }
        }       
    }
}