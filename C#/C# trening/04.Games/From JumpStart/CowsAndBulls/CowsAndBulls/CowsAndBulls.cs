using System;

class CowsAndBulls
{
    static void Main()
    {
        string playerOne, playerTwo;

        while (true)
        {
            Console.Write("Player1 secret number: ");
            Console.BackgroundColor = ConsoleColor.Gray;
            playerOne = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Black;

            if (CheckForCorectNumber(playerOne))
            {
                break;
            }
        }

        while (true)
        {
            Console.Write("Player2 secret number: ");
            Console.BackgroundColor = ConsoleColor.Gray;
            playerTwo = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Black;

            if (CheckForCorectNumber(playerTwo))
            {
                break;
            }
        }

        Console.WriteLine();

        int playerNumber = 1;
        string guessNumber;
        

        while (true)
        {
            while (true)
            {
                Console.Write("Player{0} guess the number: ",playerNumber);
                guessNumber = Console.ReadLine();

                if (CheckForCorectNumber(guessNumber))
                {
                    break;
                }
            }

            string numberToGuess = (playerNumber == 1) ? playerTwo : playerOne;
            int bulls = 0;
            int cows = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (guessNumber[i]==numberToGuess[j])
                    {
                        if (i==j)
                        {
                            bulls++;
                        }
                        else
                        {
                            cows++;
                        }
                        break;
                    }
                }
            }

            Console.WriteLine("Result: {0}bulls {1}cows",bulls,cows);
            Console.WriteLine();

            if (bulls==4)
            {
                Console.WriteLine("Player{0} Won!",playerNumber);
                int oponnent = playerNumber == 1 ? 2 : 1;
                Console.WriteLine("Player{0} Lost!", oponnent);
                break;
            }
            playerNumber = playerNumber == 1 ? 2 : 1;

        }
    }

    static bool CheckForCorectNumber(string checkNumber)
    {
        int length = 4;
        if (checkNumber.Length != length)
        {
            return false;
        }

        for (int i = 0; i < length; i++)
        {
            if (!Char.IsDigit(checkNumber[i]))
            {
                return false;   
            }
        }

        for (int i = 0; i < length; i++)
        {
            for (int j = i+1; j < length; j++)
            {
                if (checkNumber[i]==checkNumber[j])
                {
                    return false; 
                }
            }
        }
        return true;
    }
}

