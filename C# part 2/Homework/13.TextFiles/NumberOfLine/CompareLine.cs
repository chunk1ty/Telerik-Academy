using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NumberOfLine
{
    class CompareLine
    {
        static void Main()
        {
            StreamReader readOne = new StreamReader("../../test.txt");
            StreamReader readTwo = new StreamReader("../../testTwo.txt");

            int sameLine = 0;
            int differentLine = 0;

            using (readOne)
            {
                using (readTwo)
                {
                    string textOne = readOne.ReadLine();
                    string textTwo = readTwo.ReadLine();
                    
                    while (textOne != null && textTwo != null)
                    {
                        if (textOne == textTwo)
                        {
                            sameLine++;
                        }
                        else
                        {
                            differentLine++;
                        }
                        textOne = readOne.ReadLine();
                        textTwo = readTwo.ReadLine();                        
                    }
                } 
            }
            Console.WriteLine("Same lines are {0}",sameLine);
            Console.WriteLine("Different lines are {0}",differentLine);
        }
    }
}
