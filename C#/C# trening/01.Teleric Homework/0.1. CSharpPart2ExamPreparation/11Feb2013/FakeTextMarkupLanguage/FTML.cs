using System;
using System.Collections.Generic;
using System.Text;

namespace FakeTextMarkupLanguage
{
    class FTML
    {
        private const string revTagOpen = "<rev>";
        private const string upperTagOpen = "<upper>";
        private const string lowerTagOpen = "<lower>";
        private const string toggleTagOpen = "<toggle>";
        private const string delTagOpen = "<del>";

        private const string revTagClose = "</rev>";
        private const string upperTagClose = "</upper>";
        private const string lowerTagClose = "</lower>";
        private const string toggleTagClose = "</toggle>";
        private const string delTagClose = "</del>";
        
        
        static void Main()
        {
            int numberOfLine = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLine; i++)
            {
                string currentLine = Console.ReadLine();
                GetTag(currentLine);
            }
        }

        static  void GetTag (string line)
        {
            var list =new  List<string>();
            for (int i = 0; i < line.Length - 1; i++)
            {
                if (line[i] == '<')
                {
                    int currentIndexTag = line.IndexOf('>', i);
                    string currentTag = line.Substring(i, currentIndexTag - i+1);
                    i += currentTag.Length-1;
                    list.Add(currentTag);
                    if (CheckTwoTags(list))
                    {
                        string tag = list[list.Count - 1];
                        char symbol = tag[2];
                        list.Remove(list[list.Count - 2]);
                        list.Remove(list[list.Count - 1]);                        
                        
                        int indexOf = line.IndexOf('>');
                        string currentText = line.Substring(indexOf, i - indexOf);
                        string text= ProcessText(symbol, currentText);
                    }
                }                
            }
        }

        static bool CheckTwoTags(List<string> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                string firstCurrentTag = list[i - 1];
                string secondCurrentTag = list[i];
                if (firstCurrentTag[1] == secondCurrentTag[2])
                {
                    return true;
                }
            }
            return false;
        }

        static string ProcessText(char symbol, string line)
        {           
            if (symbol == 'r')
            {
                
            }
            else if (symbol == 'u')
            {
                return line = line.ToUpper();
            }
            else if (symbol == 'l')
            {
                return line = line.ToLower();
            }
            else if (symbol == 't')
            {

            }
            else if (symbol == 'd')
            {

            }
            return "";
        }
       
    }
}
