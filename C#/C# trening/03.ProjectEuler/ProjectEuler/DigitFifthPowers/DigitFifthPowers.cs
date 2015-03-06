using System;

class DigitFifthPowers
{
    static void Main()
    {
        int generalSum = 0;
        for (int i = 2; i <= 4000000; i++)                   // 355000 -> 443839
        {
            int number = i;
            int sum = 0;
            
            while (number != 0)
            {
                int lastDigit = number % 10;
                sum += (int)Math.Pow(lastDigit, 5);
                number = number / 10;
            }
            
            if (sum == i)
            {
               generalSum += i;
               // Console.WriteLine(i);
            }
        }

        Console.WriteLine(generalSum);
    }
}

