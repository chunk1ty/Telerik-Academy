using System;
using System.Collections.Generic;
using System.Text;

namespace NineGagNumbers
{
    class NineGag
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(NineGagNumbersToDecimal(input));
        }

        static List<ulong> NineGagNumbersAtList(string input)
        {
            var list = new List<ulong>();
            while (input.Length != 0)
            {
                string currentString = input.Substring(0, 2);
                if (currentString == "-!")
                {
                    list.Add(0);
                    input = input.Remove(0, 2);
                }
                else if (currentString == "**")
                {
                    list.Add(1);
                    input = input.Remove(0, 2);
                }
                else if (currentString == "!!" && input[2]== '!')
                {
                    list.Add(2);
                    input = input.Remove(0, 3);
                }
                else if (currentString == "&&")
                {
                    list.Add(3);
                    input = input.Remove(0, 2);
                }
                else if (currentString == "&-")
                {
                    list.Add(4);
                    input = input.Remove(0, 2);
                }
                else if (currentString == "!-")
                {
                    list.Add(5);
                    input = input.Remove(0, 2);
                }
                else if (currentString == "*!")
                {
                    list.Add(6);
                    input = input.Remove(0, 4);
                }
                else if (currentString == "&*")
                {
                    list.Add(7);
                    input = input.Remove(0, 3);
                }
                else
                {
                    list.Add(8);
                    input = input.Remove(0, 6);
                }
                
            }

            return list;
        }        

        static ulong NineGagNumbersToDecimal (string input)
        {
            ulong result = 0;
            List<ulong> list = NineGagNumbersAtList(input);
            list.Reverse();

            for (int i = 0; i < list.Count; i++)
            {
                ulong currentResult = list[i] * PowOfDigit(i);
                result += currentResult;
            }
            return result;
        }
        static ulong PowOfDigit (int number)
        {
            ulong result = 1;

            for (int i = 1; i <= number; i++)
            {
                result = 9 * result;
            }
            return result;
        }
    }
}


