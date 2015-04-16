using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace TraverseDirectoryLINQ
{
    class Program
    {
        //Doesn't work
        static void Main(string[] args)
        {
            TraverseDir(@"D:\Chunk1tySVN", @"..\..\..\my-directory.xml");
        }

        private static void TraverseDir(string directoryPath, string xmlResultPath)
        {
            XElement xmlDoc = new XElement("root-directory",
                        new XAttribute("path", directoryPath)
                );

            DFS(xmlDoc, directoryPath);

            xmlDoc.Save(@"..\..\..\my-directory.xml");
        }

        private static void DFS(XElement xmlDoc, string directoryPath)
        {
            foreach (var directory in Directory.GetDirectories(directoryPath))
            {
                xmlDoc = new XElement("dir", new XAttribute("name", directory));

                DFS(xmlDoc, directory);

                xmlDoc.Save(@"..\..\..\my-directory.xml");
            }

            foreach (var file in Directory.GetFiles(directoryPath))
            {
                xmlDoc = new XElement("file", new XAttribute("name", file), new XAttribute("size", new FileInfo(file).Length.ToString()));

                xmlDoc.Save(@"..\..\..\my-directory.xml");
            }
        }
    }
}