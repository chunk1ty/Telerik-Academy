using System;

class BitsExchanges
{
    static void Main()
    {
       int number = int.Parse(Console.ReadLine());
       Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        // exchange 3 nad 24th bits
        int mask = 1 << 3;
        int thirdBit = (mask & number) >> 3;
        mask = 1 << 24;
        int twentyFourthBit = (mask & number) >> 24;
       
        if (thirdBit==0)
        {
            mask = ~(1 << 24);
            number = number & mask;
        }
        else if (thirdBit == 1)
        {
            mask = 1 << 24;
            number = number | mask;
        }
        if (twentyFourthBit == 0)
        {
            mask = ~(1 << 3);
            number = number & mask;
        }
        else if (twentyFourthBit == 1)
        {
            mask = 1 << 3;
            number = number | mask;
        }

        //exchange forth and twentyFifth Bits
        mask = 1 << 4;
        int fourthBit = (mask & number) >> 4;
        mask = 1 << 25;
        int twentyFifthBit = (mask & number) >> 25;

        if (fourthBit == 0)
        {
            mask = ~(1 << 25);
            number = number & mask;
        }
        else if (fourthBit == 1)
        {
            mask = 1 << 25;
            number = number | mask;
        }
        if (twentyFifthBit == 0)
        {
            mask = ~(1 << 4);
            number = number & mask;
        }
        else if (twentyFifthBit == 1)
        {
            mask = 1 << 4;
            number = number | mask;
        }

        // exchange fifth and twenty sixth bits
        mask = 1 << 5;
        int fifthBit = (mask & number) >> 5;
        mask = 1 << 26;
        int twentySixthBit = (mask & number) >> 26;

        if (fifthBit == 0)
        {
            mask = ~(1 << 26);
            number = number & mask;
        }
        else if (fifthBit == 1)
        {
            mask = 1 << 26;
            number = number | mask;
        }
        if (twentySixthBit == 0)
        {
            mask = ~(1 << 5);
            number = number & mask;
        }
        else if (twentySixthBit == 1)
        {
            mask = 1 << 5;
            number = number | mask;
        }

        Console.WriteLine(number);
    }
}
