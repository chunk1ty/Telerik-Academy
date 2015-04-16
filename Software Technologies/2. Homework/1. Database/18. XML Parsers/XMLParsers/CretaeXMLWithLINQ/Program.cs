using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace TxtToXML
{
    //In a text file we are given the name, address and phone number of given person (each at a single line). Write a program, which creates new XML document, which contains these data in structured XML format
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            string address = string.Empty;
            string phoneNumber = string.Empty;

            using (StreamReader reader = new StreamReader("../../../persons.txt"))
            {
                name = reader.ReadLine();
                address = reader.ReadLine();
                phoneNumber = reader.ReadLine();

            }

            XElement xmlDoc = new XElement("persons",
                new XElement("person",
                    new XElement("name", name),
                    new XElement("address", address),
                    new XElement("phone-number", phoneNumber)
                    )                
                );

            Console.WriteLine(xmlDoc);

            xmlDoc.Save("../../../persons.xml");
        }
    }
}


