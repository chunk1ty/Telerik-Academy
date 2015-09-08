namespace Bunny
{
    public class AirCraft
    {

        public static int Weight
        {
            get
            {
                return 250;
            }
        }

        public decimal Fuel { get; set; }

        public AirCraft(int pilot)
        {
            this.Fuel = 200M;
        }

        public void Move()
        {
            this.Fuel -= 10M;
        }
    }
}
