namespace FigureExersice
{
    using System;
    class Circle : Shape
    {
        private int radiusC;
        public Circle(int radius):base(radius)
        {
            this.radiusC = radius;
        }        
        public override double CalculateSurface()
        {
            return Math.PI * base.Width * base.Width;
        }
    }
}
