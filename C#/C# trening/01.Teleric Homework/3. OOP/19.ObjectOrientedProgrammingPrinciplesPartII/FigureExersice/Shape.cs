namespace FigureExersice
{
    public abstract class Shape
    {
        private int width;
        private int height;
        public int Width
        {
            get 
            {
                return this.width; 
            }
            set 
            { 
                this.width = value; 
            }
        }
        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }
        public Shape(int widthh)
        {
            this.Width = widthh;
        }
        public Shape(int widthh,int heightt) : this(widthh)
        {
            this.Height = heightt;
        }        
        public abstract double CalculateSurface(); 
    }
}
