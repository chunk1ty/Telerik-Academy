using System;

namespace CharInformationInString
{
    class CharINformation
    {
        static void Main()
        {
            string text = "Andriyan Nevlinov Krastev";
            
            char[] letters = new char[65536];

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                letters[currentChar]++;                
            }

            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] > 0)
                {
                    Console.WriteLine("Char {0} is found {1} times", (char)i, (int)letters[i]);
                }
            }
        }
    }
}
