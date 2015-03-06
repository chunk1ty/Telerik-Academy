using System;

class DIvidedBy7and5
{
    static void Main()
    {
        Console.Write("Enter a integer value: ");
        int intValue = int.Parse(Console.ReadLine());
        //bool checkDivided = ((intValue % 35) == 0);
        bool checkDivided = (((intValue % 5) == 0) && ((intValue % 7) == 0));
        Console.WriteLine(checkDivided);
    }
}
