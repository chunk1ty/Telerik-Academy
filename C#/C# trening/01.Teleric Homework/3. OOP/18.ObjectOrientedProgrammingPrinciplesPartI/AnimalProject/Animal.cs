namespace AnimalProject
{
    using System;
    using System.Linq;
    public class Animal
    {
        public Animal(byte age, string name, bool isMale)
        {
            this.Age = age;
            this.Name = name;
            this.IsMale = isMale;
        }
        public byte Age { get; set; }
        public string Name { get; set; }
        public bool IsMale { get; set; }        
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.Name, this.Age, this.IsMale ? "Male" : "Female");
        }
        public static decimal AverageAge(Animal[] array)
        {
            return array.Average(x=> (decimal)x.Age);
        }

    }
}
