using System;
using System.Linq;

class MissCat
{
    static void Main()
    {
        int numbersOfJury = int.Parse(Console.ReadLine());
        int[] cats = new int[11];

        for (int i = 0; i < numbersOfJury; i++)
        {
            int mark = int.Parse(Console.ReadLine());
            cats[mark]++;
        }

        int index = 0;
        int temp = 0;

        for (int i = 0; i < cats.Length ; i++)
        {
            if (cats[i] > temp)
            {
                temp = cats[i];
                index = i;
            }
        }
        Console.WriteLine(index);



    }
}

