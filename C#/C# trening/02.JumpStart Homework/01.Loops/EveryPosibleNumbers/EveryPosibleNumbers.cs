using System;

class EveryPosibleNumbers
{
    static void Main()
    {
        Console.Write("N ");
        int n = int.Parse(Console.ReadLine());
        int nextNumber;
        int nextNextNumber;
       
        if (n<2)
        {
            Console.WriteLine("Uncorect input!");
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j  = i+1; j  <= n; j ++)
                {
                    Console.WriteLine("{0} {1}",i,j);
                }
               
            }
        }
    }
}

