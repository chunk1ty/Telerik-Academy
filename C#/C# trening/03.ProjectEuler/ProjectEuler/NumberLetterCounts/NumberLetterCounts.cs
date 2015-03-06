namespace NumberLetterCounts
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class NumberLetterCounts
    {
        static void Main()
        {
            Console.WriteLine(GenerateNumbersFromOneToOneThousand() + 11);
        }

        private static int GenerateNumbersFromOneToOneThousand()
        {
            //List<string> numbersAsWords = new List<string>();
            string numberAsWord = string.Empty;
            int counter = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (i >= 100)
                {
                    numberAsWord = NumberBiggerThanOneHundred(i);
                }
                else if (i >= 20)
                {
                    numberAsWord = NumberBiggerThanTwenty(i);
                }
                else
                {
                    numberAsWord = LowestNumbersAsWord(i);
                }

                counter += numberAsWord.Length;
            }

            return counter;
        }

        private static string LowestNumbersAsWord(int number)
        {
            string result = string.Empty;

            switch (number)
            {
                case 1: result = "one"; break;
                case 2: result = "two"; break;
                case 3: result = "three"; break;
                case 4: result = "four"; break;
                case 5: result = "five"; break;
                case 6: result = "six"; break;
                case 7: result = "seven"; break;
                case 8: result = "eight"; break;
                case 9: result = "nine"; break;
                case 10: result = "ten"; break;
                case 11: result = "eleven"; break;
                case 12: result = "twelve"; break;
                case 13: result = "thirteen"; break;
                case 14: result = "fourteen"; break;
                case 15: result = "fifteen"; break;
                case 16: result = "sixteen"; break;
                case 17: result = "seventeen"; break;
                case 18: result = "eighteen"; break;
                case 19: result = "nineteen"; break;                
                default:
                    throw new ArgumentException("Problem is somewhere between 1 and 19");
                    
            }

            return result;
        }

        private static string NumberBiggerThanTwenty(int number)
        {
            StringBuilder result = new StringBuilder();
            int numberForTwentyAndBigger = number / 10;

            switch (numberForTwentyAndBigger)
            {
                case 2: result.Append("twenty"); break;
                case 3: result.Append("thirty"); break;
                case 4: result.Append("forty"); break;
                case 5: result.Append("fifty"); break;
                case 6: result.Append("sixty"); break;
                case 7: result.Append("seventy"); break;
                case 8: result.Append("eighty"); break;
                case 9: result.Append("ninety"); break;
                default:
                    throw new ArgumentException("Problem is somewhere between 20 and 99");
            }

            int numberForLowest = number % 10;

            if (numberForLowest != 0)
            {
                result.Append(LowestNumbersAsWord(numberForLowest));
            }            

            return result.ToString();
        }

        private static string NumberBiggerThanOneHundred(int number)
        {
            StringBuilder result = new StringBuilder();

            int numberForHundred = number / 100;

            result.Append(LowestNumbersAsWord(numberForHundred));
            result.Append("Hundred");

            int numberForТens = number % 100;

            if (numberForТens != 0)
            {
                result.Append("And");
                if (numberForТens < 20)
                {
                    result.Append(LowestNumbersAsWord(numberForТens));
                }
                else if (numberForТens >= 20 && numberForТens < 100)
                {
                    result.Append(NumberBiggerThanTwenty(numberForТens));
                }
            }            

            return result.ToString();
        }
    }
}
