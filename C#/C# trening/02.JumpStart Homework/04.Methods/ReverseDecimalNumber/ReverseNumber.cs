using System;
using System.Text;
using System.Linq;

namespace ReverseDecimalNumber
{
    class ReverseNumber
    {
        static void Main()
        {
            decimal decimalNumber = decimal.Parse(Console.ReadLine());
            Console.WriteLine(ReverseDecimalValue(decimalNumber));
        }

        static string ReverseDecimalValue(decimal inputNumber)
        {
            string numberAsString = inputNumber.ToString();
            char[] numberAsCharArray = numberAsString.ToCharArray();
            StringBuilder result = new StringBuilder();           

            for (int i = numberAsString.Length-1; i >= 0; i--)
            {
                result.Append(numberAsCharArray[i]);
            }           

            return result.ToString();
        }
    }
}
