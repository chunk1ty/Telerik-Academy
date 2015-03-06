using System;

class FibonacciSequence
{
    static void Main()
    {
        decimal firstValue = 0;
        decimal secondValue = 1;
        decimal next;

        Console.WriteLine("Member   1 of sequence of Fibonacci is : {0}",firstValue);
        Console.WriteLine("Member   2 of sequence of Fibonacci is : {0}",secondValue);

        for (int i = 0; i < 98; i++)
        {
            next = firstValue + secondValue;
            firstValue = secondValue;
            secondValue = next;
            Console.WriteLine("Member {0,3} of sequence of Fibonacci is : {1}",(i+3), secondValue);
        }
    }
}

