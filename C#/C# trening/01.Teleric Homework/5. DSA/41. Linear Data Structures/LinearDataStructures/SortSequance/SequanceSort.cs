namespace SortSequance
{
    using System;
    using System.Collections.Generic;
    
    public class SequanceSort
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<int> list = new List<int>();

            while (input != string.Empty)
            {
                list.Add(int.Parse(input));
                input = Console.ReadLine();
            }

            list.Sort();
        }
    }
}
