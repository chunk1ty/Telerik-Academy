using System;
using System.Text;

namespace Zerg
{
    class ZergEx
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string number = InputToNumber(input);
            long decimalNumber = GetDecimal(number, 15);
            if (decimalNumber > 0)
            {
                string result = getNewBase(decimalNumber, 10);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(decimalNumber);
            }

        }
        static string InputToNumber(string input)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i += 4)
            {
                string currentDigit = input.Substring(i, 4);
                if (currentDigit == "Rawr")
                {
                    sb.Append(0);
                }
                else if (currentDigit == "Rrrr")
                {
                    sb.Append(1);
                }
                else if (currentDigit == "Hsst")
                {
                    sb.Append(2);
                }
                else if (currentDigit == "Ssst")
                {
                    sb.Append(3);
                }
                else if (currentDigit == "Grrr")
                {
                    sb.Append(4);
                }
                else if (currentDigit == "Rarr")
                {
                    sb.Append(5);
                }
                else if (currentDigit == "Mrrr")
                {
                    sb.Append(6);
                }
                else if (currentDigit == "Psst")
                {
                    sb.Append(7);
                }
                else if (currentDigit == "Uaah")
                {
                    sb.Append(8);
                }
                else if (currentDigit == "Uaha")
                {
                    sb.Append(9);
                }
                else if (currentDigit == "Zzzz")
                {
                    sb.Append('a');
                }
                else if (currentDigit == "Bauu")
                {
                    sb.Append('b');
                }
                else if (currentDigit == "Djav")
                {
                    sb.Append('c');
                }
                else if (currentDigit == "Myau")
                {
                    sb.Append('d');
                }
                else if (currentDigit == "Gruh")
                {
                    sb.Append('e');
                }
            }

            return sb.ToString();
        }

        static long GetDecimal(string number, long initialBase)
        {
            long decimalNumber = 0;
            char[] charArray = number.ToCharArray();
            Array.Reverse(charArray);
            number = new string(charArray);
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] < 58)
                {
                    decimalNumber += (long)((number[i] - '0') * Math.Pow(initialBase, i));
                }
                else if (number[i] < 58)
                {
                    decimalNumber += (long)((number[i] - 55) * Math.Pow(initialBase, i));
                }
                else
                {
                    decimalNumber += (long)((number[i] - 87) * Math.Pow(initialBase, i));
                }
            }
            return decimalNumber;
        }
        static string getNewBase(long number, long newBase)
        {
            string result = null;
            while (number > 0)
            {
                long reminder = number % newBase;
                if (reminder > 9)
                {
                    result += (char)(reminder + 55);
                }
                else
                {
                    result += reminder;
                }
                number = number / newBase;
            }
            char[] charArray = result.ToCharArray();
            Array.Reverse(charArray);
            result = new string(charArray);
            return result;
        }
    }
}
