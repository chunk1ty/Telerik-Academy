using System;
using System.Collections.Generic;
using System.Text;

namespace DurankulakNumbers
{
    class DuranNumbers
    {
        static void Main()
        {
            string[] durankulakNumbers = new string[168];
            List<int> result = new List<int>();
            FillArrayWithDurankulakNumbers(durankulakNumbers);

            string input = Console.ReadLine();
            result = LetterToDigit(durankulakNumbers, result, input);
            result.Reverse();
            ulong finalResult = 0;

            if (result.Count > 1)
            {
                for (int i = 0; i < result.Count; i++)
                {
                    ulong currentNumber = (ulong)result[i];
                    
                    currentNumber = currentNumber * (ulong)Math.Pow(168, i);
                    finalResult += currentNumber;
                }
                Console.WriteLine(finalResult);
            }
            else
            {
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }
           
           
        }

        private static List<int> LetterToDigit(string[] durankulakNumbers, List<int> result, string input)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                {
                    if (sb.Length == 0)
                    {
                        string currentNumber = input[i].ToString();
                        int index = Array.IndexOf(durankulakNumbers, currentNumber);
                        result.Add(index);
                    }
                    else
                    {
                        string number = sb.ToString() + input[i].ToString();
                        int index = Array.IndexOf(durankulakNumbers, number);
                        result.Add(index);
                        sb.Clear();
                    }
                    
                }
                else
                {
                    sb.Append(input[i]);
                }
            }
            return result;
        }

        static void FillArrayWithDurankulakNumbers(string[] durankulakNumbers)
        {
            for (int i = 0; i < 26; i++)
            {
                char symbol = (char)(i + 'A');
                durankulakNumbers[i] = symbol.ToString();
            }

            int position = 26;
            for (int i = 0; i < 6; i++)
            {
                char currentSymbol = (char)(i + 'a');
                for (int j = 0; j < 26 && position < 168; j++)
                {
                    char innerSymbol = (char)(j + 'A');
                    durankulakNumbers[position] = currentSymbol.ToString() + innerSymbol.ToString();
                    position++;
                }
            }
        }
    }
}
