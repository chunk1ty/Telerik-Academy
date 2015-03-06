using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AddNumberOnEveryLine
{
    class NumberOnLine
    {
        static void Main()
        {
            StreamReader read = new StreamReader("../../ReadFileTest.txt", Encoding.UTF8);
            StreamWriter write = new StreamWriter("../../OutputFile.txt");

            using (read)
            {
                using (write)
                {
                    int lineNumber = 1;
                    string line = string.Empty;
                    while (line != null)
                    {                                               
                        line = read.ReadLine();
                        if (line != null)
                        {
                            write.WriteLine("{0}. {1}", lineNumber, line);
                            lineNumber++;   
                        }                       
                    }
                }                
            }
        }
    }
}
