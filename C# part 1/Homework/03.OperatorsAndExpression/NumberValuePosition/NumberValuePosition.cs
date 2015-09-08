using System;

class NumberValuePosition
{
    static void Main()
    {
        Console.Write("Enter a integer number: ");
        int numberN = int.Parse(Console.ReadLine());
        Console.Write("Enter value(0 or 1) : ");
        int valueV = int.Parse(Console.ReadLine());
        Console.Write("Enter a position who want to change: ");
        int positionP = int.Parse(Console.ReadLine());

        if (valueV == 0)
        {
            int mask = ~(1 << positionP);    //obrushta chisloto
            int result = mask & numberN;
            Console.WriteLine(result);
        }
        else if (valueV == 1)
        {
            int mask = 1 << positionP;
            int result = mask | numberN;
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Error!");
        }
       
    }
}

