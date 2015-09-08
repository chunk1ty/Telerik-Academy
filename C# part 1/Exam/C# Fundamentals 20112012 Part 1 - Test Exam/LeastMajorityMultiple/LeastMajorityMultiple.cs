using System;

class LeastMajorityMultiple
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());

        for (int i = 1; i < int.MaxValue; i++)
        {
            int counter = 0;
            if ( i % a == 0 )
            {
                counter++;
            }
            if (i % b == 0)
            {
                counter++;
            }
            if (i % c == 0)
            {
                counter++;
            }
            if (i % d == 0)
            {
                counter++;
            }
            if (i % e == 0)
            {
                counter++;
            }

            if (counter>=3)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}
