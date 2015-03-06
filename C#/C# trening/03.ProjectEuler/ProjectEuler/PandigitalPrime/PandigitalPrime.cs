using System;
using System.Collections.Generic;

class PandigitalPrime
{
    static bool isPrime(long number)
    {

        if (number == 1) return false;
        if (number == 2) return true;

        for (long i = 3; i < number; i += 2)
        {
            if (number % i == 0) return false;
        }

        return true;

    }

    static void Main()
    {
        

        for (long i = 98765432; i >= 0; i--)
        {
            string number = i.ToString();
            int len = number.Length;
            bool check = true;

            for (int j = 0; j < len - 1; j++)
            {
                for (int k = j + 1; k < len; k++)
                {
                    if (number[j] == number[k])
                    {
                        check = false;
                        break;
                    }
                }
            }
            if (check)
            {
                bool checkPrime = isPrime(i);
                if (checkPrime)
                {
                    Console.WriteLine(i);
                    break;
                }  
            }
        }

       

        

        
    }
}

