using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ReplaceStartWithFinish
{
    class Replaces
    {
        static void Main()
        {
            StreamReader input = new StreamReader("../../input.txt");
            StreamWriter output = new StreamWriter("../../output.txt");
             
            using (input)
            {
                using (output)
                {
                    string line = input.ReadLine();
                    while (line != null)
                    {                        
                        string check = line.Replace("start", "finish");
                        output.WriteLine(check);  
                        line = input.ReadLine();                        
                    }                        
                }
            }

        }
    }
}
