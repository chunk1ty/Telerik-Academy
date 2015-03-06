namespace LargestAreaOfEmptyCells
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y) : this ()
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.X, this.Y);
        }
    }
}
