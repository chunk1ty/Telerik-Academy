using System;

class DescendingOrder
{
    static void Main()
    {
        do
        {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        //int[] numbersArray = new int[] { a, b, c };
        //Array.Sort(numbersArray);
        //Array.Reverse(numbersArray);

        //foreach (int number in numbersArray)
        //{
        //    Console.WriteLine(number);
        //}   

        if (a>=b && a>=c && b>=c)
        {
            Console.WriteLine("{0} {1} {2}",a,b,c);
        }
        else if (a>=b && a>=c && c>=b)
        {
            Console.WriteLine("{0} {1} {2}", a, c, b);
        }
        else if (b>=a && b>=c && a>=c)
        {
            Console.WriteLine("{0} {1} {2}",b,a,c);
        }
        else if (b >= a && b >= c && c >= a)
        {
            Console.WriteLine("{0} {1} {2}", b, c, a);
        }
        else if (c >= a && c >= b && a >= b)
        {
            Console.WriteLine("{0} {1} {2}", c, a, b);
        }
        else if (c >= a && c >= b && b >= a)
        {
            Console.WriteLine("{0} {1} {2}", c, b, a);
        }

        } while (true);
    }
}

