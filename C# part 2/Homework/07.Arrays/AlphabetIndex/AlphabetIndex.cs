using System;

class AlphabetIndex
{
    static void Main()
    {
        int[] myArray = new int[53];
        //a-z
        for (int i = 1; i <= 26; i++)
        {
            int index = i + 96;
            myArray[i] = index;
        }
        //A-Z
        for (int i = 27; i <= 52; i++)
        {
            int index = i + 38;
            myArray[i] = index;
        }

        string inputText = "Programmer";

        //for (int i = 0; i < inputText.Length; i++)
        //{
        //    char letter = inputText[i];
        //    int value = (int)letter;
        //    for (int j = 0; j < 53; j++)
        //    {
        //        if (value == myArray[j])
        //        {
        //            Console.WriteLine("The letter is {0} with index {1}",letter,j);
        //        }   
        //    }
        //}
        for (int i = 0; i < inputText.Length; i++)
        {
            for (int j = 0; j < 53; j++)
            {
                if (inputText[i] == myArray[j])
                {
                    Console.WriteLine("The letter is {0} with index {1}", inputText[i], j);
                    break;
                }
            }
        }
    }
}

