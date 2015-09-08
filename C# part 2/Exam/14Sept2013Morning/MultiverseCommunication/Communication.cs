using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiverseCommunication
{
    class Communication
    {
       
        static void Main()
        {
            string input = Console.ReadLine();             
         
            string number = InputToNumber(input);
            long decimalNumber = GetDecimal(number, 13);
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
        static string InputToNumber (string input)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i +=3)
            {
                string data = input.Substring(i, 3);
                if (data == "CHU")
                {
                    sb.Append(0);
                }
                else if (data == "TEL")
                {
                    sb.Append(1);
                }
                else if (data == "OFT")
                {
                    sb.Append(2);
                }
                else if (data == "IVA")
                {
                    sb.Append(3);
                }
                else if (data == "EMY")
                {
                    sb.Append(4);
                }
                else if (data == "VNB")
                {
                    sb.Append(5);
                }
                else if (data == "POQ")
                {
                    sb.Append(6);
                }
                else if (data == "ERI")
                {
                    sb.Append(7);
                }
                else if (data == "CAD")
                {
                    sb.Append(8);
                }
                else if (data == "K-A")
                {
                    sb.Append(9);
                }
                else if (data == "IIA")
                {
                    sb.Append('a');
                }
                else if (data == "YLO")
                {
                    sb.Append('b');
                }
                else if (data == "PLA")
                {
                    sb.Append('c');
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
