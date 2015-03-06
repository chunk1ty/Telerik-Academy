using System;
using System.Collections.Generic;
using System.Text;

namespace MagicWords
{
    class MagicWord
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());            
            var words = new List<string>(size);
            for (int i = 0; i < size; i++)
            {
                string input = Console.ReadLine();
                words.Add(input);
            }

            for (int i = 0; i < size; i++)
            {
                int len = words[i].Length;
                int position = len % (size + 1);
                string currentWord = words[i];
                words[i] = null;                          
                words.Insert(position, currentWord);
                words.Remove(null);                
            }
            
            StringBuilder sb = new StringBuilder();

            int maxLen = 0;
            foreach (var word in words)
            {
                if (word.Length > maxLen)
                {
                    maxLen = word.Length;
                }
            }

            for (int i = 0; i < maxLen; i++)
            {
                foreach (var word in words)
                {
                    if (word.Length > i)
                    {
                        sb.Append(word[i]);
                    }
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
