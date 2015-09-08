using System;
using System.Collections.Generic;


using System.Threading.Tasks;

namespace DictionaryExersice
{
    class DictionratyEx
    {
        static void Main()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add(".NET", "platform for applications from Microsoft");
            dictionary.Add("CLR", "managed execution environment for .NET");
            dictionary.Add("namespace", "hierarchial organization of classes");

            Console.WriteLine("Search for a word: ");
            string word = Console.ReadLine();
            string result = string.Empty;

            foreach (var entry in dictionary)
            {
                if (entry.Key.ToUpperInvariant() == word.ToUpperInvariant())
                {
                    result = entry.Value;
                }
            }

            Console.WriteLine("{0} - {1}",word,result);
        }

        
    }
}
