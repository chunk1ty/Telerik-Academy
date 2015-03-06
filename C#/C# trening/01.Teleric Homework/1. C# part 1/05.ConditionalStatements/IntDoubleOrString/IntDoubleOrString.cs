using System;

class IntDoubleOrString
{
    static void Main()
    {
        Console.WriteLine("What kind of variable you want to enter(1 for int, 2 for double, 3 for string");
        int numberForOption = int.Parse(Console.ReadLine());

        switch(numberForOption)
        {
            case 1:
                int variableInt = int.Parse(Console.ReadLine());
                variableInt++;
                Console.WriteLine(variableInt);
                break;
            case 2:
                double variableDouble = double.Parse(Console.ReadLine());
                variableDouble++;
                Console.WriteLine(variableDouble);
                break;
            case 3:
                string variableString = Console.ReadLine();
                Console.WriteLine(variableString+"*");
                break;
            default:
                Console.WriteLine("Incorrect input!");
                break;
        }
    }
}

