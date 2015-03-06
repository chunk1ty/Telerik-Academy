using System;
using System.Linq;

class BiggestNumberFromFiveNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());

        //First solution
        int big;
        int[] array = new int[] { a, b, c, d, e };

        big = array.Max();
        Console.WriteLine(big); 

        //Second solution
        //int biggestNumber=a;

        //if (biggestNumber<=b)
        //{
        //    biggestNumber = b;
        //}
        // if (biggestNumber <= c)
        //{
        //    biggestNumber = c;
        //}
        // if (biggestNumber <= d)
        //{
        //    biggestNumber = d;
        //}
        // if (biggestNumber <= e)
        //{
        //    biggestNumber = e;
        //}

        //Console.WriteLine(biggestNumber);
    }
}

