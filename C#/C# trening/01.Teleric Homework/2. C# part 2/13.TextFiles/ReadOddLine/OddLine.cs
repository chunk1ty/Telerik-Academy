using System;
using System.IO;
using System.Text;

namespace ReadOddLine
{
    class OddLine
    {
        static void Main()
        {
            string fileName = @"..\..\ReadFileTest.txt";
            //Encoding.UTF8 for reading Cyrillic
            StreamReader reader = new StreamReader(fileName, Encoding.UTF8);      

            using (reader)
            {
                int line = 1;
                string fileContent = reader.ReadLine();
                while (fileContent != null )
                {
                    if (!(line % 2 == 0))
                    {                        
                        Console.WriteLine(fileContent);
                    }
                    fileContent = reader.ReadLine();
                    line++;
                }     
            }
        }
    }
}
