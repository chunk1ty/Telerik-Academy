using System;

class OddNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        long oddNumber = 0;

        for (int i = 0; i < n; i++)
        {
            long currentNUmber = long.Parse(Console.ReadLine());
            oddNumber ^= currentNUmber;
        }

        Console.WriteLine(oddNumber);
    }
}

