using System;
using System.Text;

namespace DecodeAndDecrypt
{
    class Decode
    {
        static void Main()
        {
            string input = Console.ReadLine();
            //string input = "ANK17U9";
            int lenOfCypher = LengthOfCypher(ref input);
            string allText = RemoveNumbersFromInput(input);
                        
            string cypher = allText.Substring((allText.Length - lenOfCypher), lenOfCypher);
            string message = allText.Substring(0, (allText.Length - lenOfCypher));

            //char[] alphabet = new char[60];
            //FillArrayWithAlphabet(alphabet);

            //if (message.Length >= cypher.Length)
            //{
            //    MessageIsLongestThanCypher(cypher, message, alphabet);
            //}
            //else
            //{
            //    CypherIsLongestThanMessage(cypher, message, alphabet);
            //}
            Encrypt(message, cypher);
        }

        static void CypherIsLongestThanMessage(string cypher, string message, char[] alphabet)
        {
            StringBuilder sb = new StringBuilder();
            string realCypher = cypher.Substring(0, message.Length);
            string anotherCypher = cypher.Substring(message.Length, cypher.Length - message.Length);
            int counter = 0;
            for (int i = 0; i < message.Length; i++)
            {
                int currentMessageLetter = Array.BinarySearch(alphabet, message[i]);
                for (int j = counter; j < realCypher.Length; )
                {
                    int currentCypherLetter = Array.BinarySearch(alphabet, realCypher[j]);
                    if (j < anotherCypher.Length)
                    {
                        int currentBonusLetetr = Array.BinarySearch(alphabet, anotherCypher[j]);
                        int result = ((currentMessageLetter ^ currentCypherLetter) ^ currentBonusLetetr) + 65;
                        sb.Append((char)result);
                    }
                    else
                    {
                        int result = (currentMessageLetter ^ currentCypherLetter) + 65;
                        sb.Append((char)result);
                    }
                    counter++;
                    break;
                }
            }
            Console.WriteLine(sb);
        }

        static void MessageIsLongestThanCypher(string cypher, string message, char[] alphabet)
        {
            int counter = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < message.Length; i++)
            {
                int currentMessageChar = Array.BinarySearch(alphabet, message[i]);
                for (int j = counter; j < cypher.Length; )
                {
                    int currentCypherChar = Array.BinarySearch(alphabet, cypher[j]);
                    int result = (currentMessageChar ^ currentCypherChar) + 65;
                    sb.Append((char)result);
                    counter++;
                    if (counter == cypher.Length)
                    {
                        counter = 0;
                    }
                    break;
                }

            }
            Console.WriteLine(sb);
        }

        //Another solution
        static string Encrypt(string message,string cypher)
        {
            StringBuilder sb = new StringBuilder(message);
            int steps = Math.Max(message.Length, cypher.Length);
            for (int step = 0; step < steps; step++)
            {
                int indexOfMessage = step % message.Length;
                int indexOfCypher = step % cypher.Length;
                sb[indexOfMessage] = (char)(((sb[indexOfMessage] - 'A') ^ (cypher[indexOfCypher] - 'A')) + 'A');

            }

            return sb.ToString();
        }

        static string RemoveNumbersFromInput(string input)
        {
            StringBuilder sb = new StringBuilder();
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    count = count * 10;
                    count = count + (input[i] - '0');
                }
                else
                {
                    if (count == 0)
                    {
                        sb.Append(input[i]);
                    }
                    else
                    {
                        sb.Append(input[i], count);
                        count = 0;
                    }
                }
            }
            return sb.ToString();
        }

        static int LengthOfCypher(ref string input)
        {
            int lastIndex = input.Length - 1;
            StringBuilder sb = new StringBuilder();
            for (int i = lastIndex; i >= 0; i--)
            {
                if (Char.IsDigit(input[i]))
                {
                    sb.Append(input[i]);
                    input = input.Remove(i);
                }
                else
                {
                    break;
                }
            }
            string result = sb.ToString();
            sb.Clear();            
            for (int i = result.Length - 1; i >= 0; i--)
            {
                sb.Append(result[i]);
            }
            return int.Parse(sb.ToString());
        }

        static char[] FillArrayWithAlphabet(char[] myArray)
        {            
            int i = 65;
            for (int index = 0; index < 60; index++, i++)
            {
                myArray[index] = (char)i;
            }
            return myArray;
        }
    }
}
