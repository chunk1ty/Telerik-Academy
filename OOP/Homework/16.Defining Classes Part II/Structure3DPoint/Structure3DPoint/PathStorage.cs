namespace Structure3DPoint
{
    using System;
    using System.IO;
    static class PathStorage
    {
        public static void SavePath(Path path)
        {
            StreamWriter sw = new StreamWriter("../../SavePath");
            using (sw)
            {
                sw.Write(path);
            }
        }
        public static void LoadPath()
        {
            Path path = new Path();
            StreamReader reader = new StreamReader("../../SavePath");
            using (reader)
            {
                string currentLine = reader.ReadLine();
                while (currentLine != null)
                {
                    string[] lineNumbers = currentLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    Point3D currentPoint = new Point3D(int.Parse(lineNumbers[0]), int.Parse(lineNumbers[1]), int.Parse(lineNumbers[2]));
                    path.AddPoint(currentPoint);
                    Console.WriteLine(currentPoint);
                    currentLine = reader.ReadLine();
                }
            }
        }
    }
}
