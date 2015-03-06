using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class RandomName
{
    public static Random rnd = new Random();

    public static void Main()
    {
        string random = GetRandomName();
        Console.WriteLine(random);
    }

    public static string GetRandomName()
    {
        StringBuilder name = new StringBuilder();
        name.Append((char)rnd.Next(65, 91));
        for (int i = 0; i < rnd.Next(2, 6); i++)
        {
            name.Append((char)rnd.Next(97, 123));
        }

        return name.ToString();
    }
}