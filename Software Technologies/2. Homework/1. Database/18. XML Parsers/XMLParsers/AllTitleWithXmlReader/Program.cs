namespace AllTitleWithXmlReader
{
    using System;
    using System.Xml;

    class Program
    {
        static void Main()
        {
            using (XmlReader reader = XmlReader.Create("../../../catalogue.xml"))
            {
                while (reader.Read())
                {
                    if ((reader.Name == "title") && (reader.NodeType == XmlNodeType.Element))
                    {
                        Console.WriteLine(reader.ReadInnerXml());
                    }
                }
            }
        }
    }
}
