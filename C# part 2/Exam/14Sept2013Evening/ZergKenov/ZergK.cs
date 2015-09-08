namespace ZergCommunication
{

    using System;
    public class ZergK
    {
        public static void Main()
        {
            Console.WriteLine(ConvertZergNumber(Console.ReadLine()));
        }

        // converts from "zerg" digit to normal 15-th based digit
        public static int ConvertDigitFromZerg(string zergDigit)
        {
            switch (zergDigit)
            {
                case "Rawr": return 0;
                case "Rrrr": return 1;
                case "Hsst": return 2;
                case "Ssst": return 3;
                case "Grrr": return 4;
                case "Rarr": return 5;
                case "Mrrr": return 6;
                case "Psst": return 7;
                case "Uaah": return 8;
                case "Uaha": return 9;
                case "Zzzz": return 10;
                case "Bauu": return 11;
                case "Djav": return 12;
                case "Myau": return 13;
                case "Gruh": return 14;
                default: throw new ArgumentException();
            }
        }

        // converts number from "zerg" number to normal 13-th based number
        public static long ConvertZergNumber(string input)
        {
            long result = 0;
            int position = input.Length / 4 - 1;

            for (int i = 0; i < input.Length; i += 4)
            {
                int currentDigit = ConvertDigitFromZerg(input.Substring(i, 4));
                result += currentDigit * PowerOfFifteen(position);
                position--;
            }
             return result;
        }

      

        // get the power of 15
        public static long PowerOfFifteen(int power)
        {
            long result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= 15;
            }

            return result;
        }
    }
}
