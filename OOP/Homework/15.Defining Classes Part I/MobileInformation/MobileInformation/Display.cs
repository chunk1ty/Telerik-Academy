namespace MobileInformation
{
    public class Display
    {
        //Fields
        private int size;
        private int numberOfColors;

        //Properties
        public int Size 
        {
            get { return this.size; }
            set { this.size = value; } 
        }
        public int NumberOfColors 
        {
            get { return this.numberOfColors; }
            set { this.numberOfColors = value; } 
        }

        //Constructor
        public Display()
        {

        }
        public Display(int displaySize,int displayColors)
        {
            this.Size = displaySize;
            this.NumberOfColors = displayColors;
        }
    }
}
