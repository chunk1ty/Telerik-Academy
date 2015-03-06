using System;

class Hangman
{
    static void Main()
    {

        string[] fruits = { "apple", "pear", "appricot", "cherry", "peach", "melon" };
        Random random = new Random();
        int index = random.Next(fruits.Length);
        string word = fruits[index];

        int life = 5;
        bool[] isLetterShow = new bool[word.Length];
        Console.WriteLine("Guess the word!");
        int guessedLetters = 0;

        while (true)
        {
            Console.Write("Result: ");
            for (int i = 0; i < word.Length; i++)
            {
                if (isLetterShow[i])
                {
                    Console.Write(word[i]);
                }
                else
                {
                    Console.Write(" _ ");
                }  
            }
            Console.WriteLine();
            Console.Write("Letter: ");
            ConsoleKeyInfo keyInfo = Console.ReadKey();            //enter letter from KB
            Console.WriteLine();
            Console.WriteLine();

            bool hit = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]==keyInfo.KeyChar)
                {
                    hit = true;
                    if (!isLetterShow[i])
                    {
                        guessedLetters++;
                        isLetterShow[i] = true;
                    }       
                }   
            }

            if (!hit)
            {
                life--;
                Console.WriteLine("No hits! You have {0} life left!",life);
                Console.WriteLine();
            }
            if (life==0)
            {
                Console.WriteLine("Game Over!");
                Console.WriteLine("The word is : {0}",word);
                break;
            }
            if (guessedLetters==word.Length)
            {
                Console.WriteLine("Congratilations!");
                Console.WriteLine("The word is : {0}", word);
                break;
            }
        }
    }
}

