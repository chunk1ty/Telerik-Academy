namespace FigureExersice
{
    using System;
    class TestProgram
    {
        static void Main()
        {
            Shape[] shapes = 
            {
                new Circle(5),
                new Rectangle(2,3),
                new Triange (4,6)
            };
            
            foreach (var item in shapes)
            {                
               Console.WriteLine(item.GetType().Name +" " + item.CalculateSurface());   
            }
        }
    }
}
