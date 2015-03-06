using System;
using System.Collections.Generic;
using System.Numerics;

class DistinctPowers
{
    static void Main()
    {

        List<BigInteger> list = new List<BigInteger>();

        for (int i = 2; i <= 100; i++)
        {
            for (int j = 2; j <= 100; j++)
            {
                BigInteger number = (BigInteger)Math.Pow(i, j);

                if (i == 2 && j == 2)
                {
                    list.Add(number);
                }
                else
                {
                    bool check = true;
                    for (int k = 0; k < list.Count; k++)
                    {
                        if (list[k] == number)
                        {
                            check = false;
                            break;
                        }
                    }

                    if (check==true)
                    {
                        list.Add(number);
                    }
                }
            }
        }

        list.Sort();
        //foreach (var item in list)
        //{
        //    Console.Write("{0} ",item);
        //}
        //Console.WriteLine();
       Console.WriteLine(list.Count);
    }
}
