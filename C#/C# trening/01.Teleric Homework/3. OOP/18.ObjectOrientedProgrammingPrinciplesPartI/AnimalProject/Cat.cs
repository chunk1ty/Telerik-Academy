namespace AnimalProject
{
    public class Cat : Animal,ISound
    {
        public Cat(byte age, string name, bool isMale) : base(age, name, isMale)
        {

        }
        public  void ProduceSound()
        {
            System.Console.WriteLine("Miayyyyy");
        }
    }
}
