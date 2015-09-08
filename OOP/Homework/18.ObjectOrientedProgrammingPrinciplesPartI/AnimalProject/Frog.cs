namespace AnimalProject
{
    public class Frog : Animal,ISound
    {
        public Frog(byte age, string name, bool isMale)
            : base(age, name, isMale)
        {

        }
        public  void ProduceSound()
        {
            System.Console.WriteLine("Frog sound!");
        }
    }
}
