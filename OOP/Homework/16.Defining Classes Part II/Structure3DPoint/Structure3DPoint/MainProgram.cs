namespace Structure3DPoint
{
    using System;
    class MainProgram
    {
        static void Main()
        {
            Point3D point = new Point3D(1, 2, 3);
            Point3D point1 = new Point3D(11, 21, 31);
            Point3D point2 = new Point3D(12, 22, 32);
            Point3D point3 = new Point3D(13, 23, 33);

            Console.WriteLine(CalculateDistance.Distance(Point3D.StartPoint, point));

            Path p = new Path();
            PathStorage.LoadPath();
            //p.AddPoint(point);
            //p.AddPoint(point1);
            //p.AddPoint(point2);
            //PathStorage.SavePath(p);
            Console.WriteLine(p);
            
        }
    }
}
