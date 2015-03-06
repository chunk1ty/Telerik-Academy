using System;

class SumOfN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if ( n <= 0)
        {
            Console.WriteLine("Uncorecct input!");
        }
        else
        {
            int sum = 0;
            int lastDigit = 0;
            while (n != 0)
            {
                lastDigit = n % 10;
                sum = sum + lastDigit;
                n = n / 10;
            }
            Console.WriteLine(sum);
        }
    }
}

