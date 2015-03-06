namespace FigureExersice
{
    public class Rectangle : Shape
    {
        public Rectangle(int width, int height) : base(width, height)
        {
        }
        public override double CalculateSurface()
        {
            return Height * Width;
        }
    }
}
