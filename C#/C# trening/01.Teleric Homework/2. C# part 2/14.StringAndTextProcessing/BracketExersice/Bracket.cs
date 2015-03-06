using System;
using System.Collections.Generic;

namespace BracketExersice
{
    class Bracket
    {
        static void Main()
        {
            string input = Console.ReadLine();           
            CheckPositionOfBrackets(input);
        }

        static void CheckPositionOfBrackets(string inputData)
        {
            int counter = 0;
            for (int i = 0; i < inputData.Length; i++)
            {
                if (inputData[i]==')')
                {
                    counter--;
                }
                if (inputData[i] == '(')
                {
                    counter++;
                }
                if (counter<0)
                {                    
                    break;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("Correct input");
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }        
    }
}
