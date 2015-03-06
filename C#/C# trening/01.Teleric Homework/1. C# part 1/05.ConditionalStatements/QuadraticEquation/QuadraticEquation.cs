using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("ax^2+bx+c=0");
        Console.Write("Enter a: ");
        decimal coefficientA = decimal.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        decimal coefficientB = decimal.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        decimal coefficientC = decimal.Parse(Console.ReadLine());

        decimal discriminantD = coefficientB * coefficientB - 4 * coefficientA * coefficientC;

        if (discriminantD > 0)
        {
            decimal rootOne = (-coefficientB + (decimal)Math.Sqrt((double)discriminantD)) / (2 * coefficientA);
            decimal rootTwo = (-coefficientB - (decimal)Math.Sqrt((double)discriminantD)) / (2 * coefficientA);
            Console.WriteLine("The first root is  : " + rootOne);
            Console.WriteLine("The second root is : " + rootTwo);
        }
        else if (discriminantD == 0)
        {
            decimal root = -coefficientB / (2 * coefficientA);
            Console.WriteLine("You have only one root and his value is : " + root);
        }
        else if (discriminantD < 0)
        {
            Console.WriteLine("Discriminant is negative!");
        }
        else
        {
            Console.WriteLine("The program working incorrect!");
        }

    }
}

