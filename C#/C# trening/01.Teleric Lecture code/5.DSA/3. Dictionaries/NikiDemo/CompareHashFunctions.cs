using System;
using System.Collections.Generic;
using System.Diagnostics;
public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }
    public override bool Equals(Object obj)
    {
        if (!(obj is Point) || (obj == null)) return false;
        Point p = (Point)obj;
        return (X == p.X) && (Y == p.Y);
    }
    public override int GetHashCode()
    {
        return (X << 16 | X >> 16) ^ Y;
    }
}
public struct JustPoint
{
    public int X { get; set; }
    public int Y { get; set; }
    public override int GetHashCode()
    {
        return 0;
		// return X ^ Y;
    }

    public override bool Equals(Object obj)
    {
        if (!(obj is Point) || (obj == null)) return false;
        Point p = (Point)obj;
        return (X == p.X) && (Y == p.Y);
    }
}

class CompareHashFunctions
{
    static void Main()
    {
        const int count = 20000;
        Random rand = new Random();

        Stopwatch sw = new Stopwatch();
        sw.Start();
        var points = new HashSet<Point>();
        for (int i = 0; i < count; i++)
        {
            points.Add(new Point() { X = rand.Next(), Y = rand.Next() });
        }
        for (int i = 0; i < count; i++)
        {
            points.Contains(new Point() { X = rand.Next(), Y = rand.Next() });
        }
        sw.Stop();
        Console.WriteLine(sw.Elapsed);

        sw.Reset();
        sw.Start();
        var justPoints = new HashSet<JustPoint>();
        for (int i = 0; i < count; i++)
        {
            justPoints.Add(new JustPoint() { X = rand.Next(), Y = rand.Next() });
        }
        for (int i = 0; i < count; i++)
        {
            justPoints.Contains(new JustPoint() { X = rand.Next(), Y = rand.Next() });
        }
        sw.Stop();
        Console.WriteLine(sw.Elapsed);
    }
}
