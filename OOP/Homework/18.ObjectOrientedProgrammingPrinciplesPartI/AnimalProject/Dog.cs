namespace AnimalProject
{
    public class Dog : Animal,ISound
    {
        public Dog(byte age, string name, bool isMale) : base(age, name, isMale)
        {
        }
        public  void ProduceSound()
        {
            System.Console.WriteLine("Bayyyyy");
        }
    }
}
