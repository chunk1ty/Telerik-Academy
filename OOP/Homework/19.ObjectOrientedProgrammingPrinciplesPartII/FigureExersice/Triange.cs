namespace FigureExersice
{
    public class Triange : Shape
    {
        public Triange(int width, int height) : base(width, height)
        {
        }
        public override double CalculateSurface()
        {
            return (Height * Width) / 2.0;
        }
    }
}
