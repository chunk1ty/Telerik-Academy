using System;

namespace LastDigitInEnglishWord
{
    class DigitInWord
    {
        static void Main()
        {
            int number = TakeLastDigit();
            PrintEnglishWord(number);
        }

        static int TakeLastDigit()
        {
            Console.Write("Enter some number: ");
            int number = int.Parse(Console.ReadLine());
            int lastDigit = number % 10;
            // check for negativ number
            if (lastDigit <= 0)
            {
                lastDigit = -lastDigit;
            }
            return lastDigit;
        }

        static void PrintEnglishWord(int number)
        {
            switch (number)
            {
                case 0: Console.WriteLine("zero"); break;
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eigth"); break;
                case 9: Console.WriteLine("nine"); break;
                default: Console.WriteLine("Incorrect input!"); break;
            }
        }
    }
}
