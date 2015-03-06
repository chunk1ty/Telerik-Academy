namespace AnimalProject
{
    using System;
    class Test
    {
        static void Main()
        {
            Dog[] dog = 
               {
                   new Dog(11,"Sharo",true),
                   new Dog(7,"Asencho",true),
                   new Dog(5,"Masha",false),
               };
            Cat[] cat = 
               {
                   new Cat(11,"Marcho",true),
                   new Cat(7,"Sparky",true),
                   new Cat(5,"Misha",false),
               };
            decimal average = Animal.AverageAge(dog);
            Console.WriteLine(average);

            dog[1].ProduceSound();
            cat[1].ProduceSound();

            Kitten kitty = new Kitten("aaa", 11, true);
            Console.WriteLine(kitty);
        }
    }
}
