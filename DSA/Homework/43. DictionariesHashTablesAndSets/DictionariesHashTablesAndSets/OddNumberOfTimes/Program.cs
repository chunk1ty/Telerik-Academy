namespace OddNumberOfTimes
{
    using System;
    using System.Collections.Generic;
   
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {"C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            CountAllWords(words, wordsCount);

            foreach (var word in wordsCount)
            {
                if (word.Value % 2 != 0)
                {
                    Console.WriteLine(word.Key);
                }
            }
        }

        private static void CountAllWords(string[] words, Dictionary<string, int> wordsCount)
        {
            foreach (var word in words)
            {
                int count = 1;
                if (wordsCount.ContainsKey(word))
                {
                    count = wordsCount[word] + 1;
                }
                else
                {
                    wordsCount.Add(word, 1);
                }

                wordsCount[word] = count;
            }
        }
    }
}
