using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DeleteOddLines
{
    class EvenLines
    {
        static void Main()
        {   
            List<string> list = new List<string>();

            ReadTextFile(list);
            SaveEvenLine(list);
        }

        static void SaveEvenLine(List<string> list)
        {
            StreamWriter writer = new StreamWriter("../../NumberOnLine.cs");
            using (writer)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    writer.WriteLine(list[i]);
                }
            }
        }

        static List<string> ReadTextFile(List<string> list)
        {
            StreamReader reader = new StreamReader("../../NumberOnLine.cs");
            string textFileContain = string.Empty;
            int lineNumber = 1;
            using (reader)
            {
                textFileContain = reader.ReadLine();

                while (textFileContain != null)
                {
                    if (lineNumber % 2 == 0)
                    {
                        list.Add(textFileContain);
                    }
                    lineNumber++;
                    textFileContain = reader.ReadLine();
                }
            }
            return list;
        }
    }
}
