namespace BiDictionaryTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        static void Main(string[] args)
        {
            BiDictionary<string, string, string> myDictonary = new BiDictionary<string, string, string>();

            myDictonary.Add("Ivan", "Ivanov", "Student");
            myDictonary.Add("Ivan", "Ivanov", "Player");
            myDictonary.Add("Stoqn", "Ivanov", "Teacher");
            myDictonary.Add("Kiril", "Petkov", "Programmer");
            
            var test = myDictonary.FindByFirstKey("Ivan");
            var test1 = myDictonary.FindBySecondKey("Ivanov");
            myDictonary.RemoveByBothKeys("Ivan", "Petkov");
            Console.WriteLine(test1);
            //var test2 = myDictonary.FindByFirstAndSecondKey("Ivan", "Ivanov");
            //foreach (var item in test2)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine(myDictonary.Count);
        }
    }
}
