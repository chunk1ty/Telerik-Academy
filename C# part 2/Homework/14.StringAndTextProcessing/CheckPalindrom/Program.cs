using System;

namespace CheckForPalindrom
{
    class CheckPalindrom
    {
        static void Main()
        {
            string input = "some text here blalbal exe ABBA exe";

            char[] separators = { ' ', ',', '!', '?' };
            string[] inputAsString = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            int length = inputAsString.Length;
            for (int i = 0; i < inputAsString.Length; i++)
            {
                if (getStatus(inputAsString[i]))
                {
                    Console.WriteLine(inputAsString[i]);
                }
            }
        }

        public static bool getStatus(string myString)
        {
            int length = myString.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (myString[i] != myString[length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

    }
}