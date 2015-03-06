namespace AnimalProject
{
    public class Tomcat : Cat,ISound
    {
        public Tomcat(string name, byte age, bool isMale)
            : base(age, name, true)
        {

        }
        public  void ProduceSound()
        {
            System.Console.WriteLine("Miayyy from tomcat");
        }
    }
}
