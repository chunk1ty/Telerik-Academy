namespace AnimalProject
{
    public class Kitten : Cat,ISound
    {
        public Kitten(string name, byte age, bool isMale)
            : base(age, name, false)
        {

        }
        public  void ProduceSound()
        {
            System.Console.WriteLine("Miayy from kitten");
        }
    }
}
