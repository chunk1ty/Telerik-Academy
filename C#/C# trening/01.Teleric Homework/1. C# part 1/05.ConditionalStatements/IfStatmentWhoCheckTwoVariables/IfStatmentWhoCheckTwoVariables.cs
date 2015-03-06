using System;

class IfStatmentWhoCheckTwoVariables
{
    static void Main()
    {
        int firstVariable = int.Parse(Console.ReadLine());
        int secondVariable = int.Parse(Console.ReadLine());

        int temp;
        if(firstVariable>secondVariable)
        {
            temp = firstVariable;
            firstVariable = secondVariable;
            secondVariable = temp;
        }
        Console.WriteLine(firstVariable);
        Console.WriteLine(secondVariable);
    }
}

