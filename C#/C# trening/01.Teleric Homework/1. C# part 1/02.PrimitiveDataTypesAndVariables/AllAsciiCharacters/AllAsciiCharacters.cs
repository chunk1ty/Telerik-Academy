using System;

class AllAsciiCharacters
{
    static void Main()
    {
        int i;
        for (i = 0; i <= 255; i++)
        Console.WriteLine("ASCII value of character {0}, {1}", (char)i, i);

    }
}

