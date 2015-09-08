using System;

class CalculatesNNumbers
{
    static void Main()
    {
        Console.Write("How many numbers you want to enter : ");
        int numberN = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 0; i < numberN; i++)
        {
            Console.Write("Enter {0} number ",(i+1));
            int randomN = int.Parse(Console.ReadLine());
            sum += randomN;
        }
        Console.WriteLine(sum);
    }
}

