namespace CountWordsFromFIle
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            
            string text = string.Empty;

            text = ReadFromFile(text);

            string[] tokens = text.Split(new char[] { ' ', '.', ',', '-', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            
            SortedDictionary<string, int> wordCounts = new SortedDictionary<string, int>();

            CountWord(tokens, wordCounts);

            foreach (var word in wordCounts.OrderBy(key => key.Value))
           {
                Console.WriteLine(word.Key + "->" + word.Value);
           }
        }

        private static void CountWord(string[] tokens, SortedDictionary<string, int> wordCounts)
        {
            for (int i = 0; i < tokens.Length; i++)
            {
                string currentWord = tokens[i].ToLower();
                int count = 1;

                if (wordCounts.ContainsKey(currentWord))
                {
                    count = wordCounts[currentWord] + 1;
                }
                else
                {
                    wordCounts.Add(currentWord, 1);
                }

                wordCounts[currentWord] = count;
            }
        }

        private static string ReadFromFile(string text)
        {
            StreamReader read = new StreamReader(@"..\..\text.txt");

            using (read)
            {
                text = read.ReadToEnd();
            }
            return text;
        }
    }
}
