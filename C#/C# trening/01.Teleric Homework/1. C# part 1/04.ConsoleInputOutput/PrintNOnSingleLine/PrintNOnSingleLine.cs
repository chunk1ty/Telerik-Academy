using System;

class PrintNOnSingleLine
{
    static void Main()
    {
        Console.Write("Enter N : ");
        int numberN = int.Parse(Console.ReadLine());
       
        for (int i = 1; i <= numberN; i++)
        {
            Console.WriteLine(i);   
        }
    }
}

