using System;

class MathExpression
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());

        double firstExpression = 0.0;
        double secondExpression = 0.0;
        int thirdExpression = 0;

        firstExpression = (n * n) + (1 / (m * p)) + 1337;
        secondExpression = n - (128.523123123 * p);
        thirdExpression = (int)m % 180;

        double result = firstExpression / secondExpression + Math.Sin(thirdExpression);
        Console.WriteLine("{0:f6}",result);

    }
}

