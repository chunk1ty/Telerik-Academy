using System;

class PrintUpperLetter
{
    static void Main()
    {
        string someText = "The wolf of Wall Street";
        
        string[] splitString = someText.Split();
        
        for (int index = 0; index < splitString.Length; index++)
        {
            string currentString = splitString[index];
            char ch = currentString[0];
            if (Char.IsUpper(ch))
            {
                Console.Write("{0} ", splitString[index]);   
            }
        }
        Console.WriteLine();
    }
}

