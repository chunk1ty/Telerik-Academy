using System;

class DigitFactorials
{
    static void Main()
    {
        int sumFromOneNumber = 0;
        int generalSum = 0;

        for (int i = 145; i < 50000000; i++)
        {
            int number = i;
            sumFromOneNumber = 0;
            while (number != 0)
            {
                int factorialSum = 1;
                int lastDigit = number % 10;
                for (int j = 1; j <=lastDigit; j++)
                {
                    factorialSum *= j;
                }
                sumFromOneNumber += factorialSum;
                number = number / 10;
            }

            if (sumFromOneNumber==i)
            {
                generalSum += i;
                //Console.WriteLine(i);
            }
        }

        Console.WriteLine(generalSum);
    }
}
