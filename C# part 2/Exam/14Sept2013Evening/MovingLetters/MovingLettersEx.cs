using System;
using System.Collections.Generic;
using System.Text;

namespace MovingLetters
{
    class MovingLettersEx
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] inputAsString = input.Split(' ');

            MoveLetters(inputAsString);

        }

       static int LongestWordLength(string[] inputAsString)
        {
            int maxLen = 0;
            foreach (var word in inputAsString)
            {
                if (maxLen < word.Length)
                {
                    maxLen = word.Length;
                }
            }
            return maxLen;
        }

       static StringBuilder ExtractsLetters(string[] inputAsString)
       {
           StringBuilder sb = new StringBuilder();
           int maxLenWord = LongestWordLength(inputAsString);
           for (int i = 0; i < maxLenWord; i++)
           {
               for (int j = 0; j < inputAsString.Length; j++)
               {
                   string currentWord = inputAsString[j];
                   if (currentWord.Length > i)
                   {
                       int lastIndex = currentWord.Length - 1 - i;
                       sb.Append(currentWord[lastIndex]);
                   }
               }
           }
           return sb;
       }

       static void MoveLetters(string[] inputAsString)
       {
           StringBuilder sb = ExtractsLetters(inputAsString);
           for (int i = 0; i < sb.Length; i++)
           {
               char currentSymbol = sb[i];
               int transition = char.ToLower(currentSymbol) - 'a' + 1;
               int nextPosition = (i + transition) % sb.Length;
               sb.Remove(i, 1);               
               sb.Insert(nextPosition, currentSymbol);
           }

           Console.WriteLine(sb.ToString());
       }
    }
}
