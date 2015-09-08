namespace Bunny
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    using NumeralSystems;

    public class Program
    {
        static void Main()
        {
            AirCraft boing = new AirCraft(1);
            boing.Fuel = 100M;

            AirCraft battleCruiser = new AirCraft(2);

            //Console.WriteLine(boing.Fuel);
            //Console.WriteLine(battleCruiser.Fuel);

            boing.Move();
            //Console.WriteLine(AirCraft.Weight);
            //Console.ReadLine();

            //Console.WriteLine(NumeralSystem.ToDecimal(15M, 2));

            Point pt = new Point();
            pt.X = 5;
            pt.Y = 10;

            Point secondPoint = new Point(0, 0, 0);

            secondPoint.Add(1, 2, 3);

            Console.WriteLine(secondPoint.X);

            Point.Calculate(pt, secondPoint);

            List<int> listOfIntegers = new List<int>();
            List<string> listOfStrings = new List<string>();

            List<object> list = new List<object>();

            list.Add(10);
            list.Add(5);

            listOfIntegers.Add(5);
            listOfStrings.Add("string");
        }
    }
}
