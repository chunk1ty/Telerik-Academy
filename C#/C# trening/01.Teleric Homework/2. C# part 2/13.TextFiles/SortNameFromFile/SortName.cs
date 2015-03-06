using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SortNameFromFile
{
    class SortName
    {
        static void Main()
        {
            List<string> listOfNames = new List<string>();

            ReadNamesFromFileAndSaveInList(listOfNames);
            WriteSortedNamesAtFile(listOfNames);

            Console.WriteLine("The strings are sorted successfully.");
        }

        static void WriteSortedNamesAtFile(List<string> listOfNames)
        {
            StreamWriter writer = new StreamWriter("../../SortedName.txt");
            using (writer)
            {
                for (int i = 0; i < listOfNames.Count; i++)
                {
                    writer.WriteLine(listOfNames[i]);
                }
            }            
        }

        static List<string> ReadNamesFromFileAndSaveInList(List<string> list)
        {
            StreamReader reader = new StreamReader("../../UnSortName.txt");            

            using (reader)
            {
                string name = reader.ReadLine();
                while (name != null)
                {
                    list.Add(name);
                    name = reader.ReadLine();
                }
            }
            list.Sort();
            return list;
        }
    }
}
