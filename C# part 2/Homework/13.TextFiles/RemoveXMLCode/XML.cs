using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace RemoveXMLCode
{
    class XML
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("../../code.txt");
            string textContent = string.Empty;

            using (reader)
            {
                textContent = reader.ReadToEnd();
            }
            
            for (int i = 0; i < textContent.Length-1; i++)
            {
                char currentSymbol = textContent[i];
                if (textContent[i] == '>' && textContent[i+1] != '<')
                {
                    while (true)
                    {
                        if (textContent[i+1] == '<')
                        {
                            break;
                        }
                        Console.Write(textContent[i+1]);
                        i++;                        
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
