namespace HumanProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Test
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Andriyan","Krastev",12),
                new Student("Aseng","Asenov",11),
                new Student("Peshof","Krastev",9),
                new Student("Ivana","Ivanov",9),
                new Student("Petars","Petrov",5),
                new Student("Georgi","Georgievf",11),
                new Student("Ivailoa","Petrov",12),
                new Student("Anatoliz","Nenov",9),
                new Student("Sashoqq","Ivanov",10),
                new Student("Borislav","Petkovg",1)
            };

            var sortedStudent = students.OrderBy(x => x.Grade).ThenBy(x => x.FirstName);

            //foreach (var item in sortedStudent)
            //{
            //    Console.WriteLine(item);
            //}

            List<Worker> workers = new List<Worker>()
            {
                new Worker ("Andriyan","Krastve",300,7),
                new Worker("Asen","Asenov",350,7),
                new Worker("Pesho","Krastev",250,6),
                new Worker("Ivan","Ivanov",600,12),
                new Worker("Petar","Petrov",330,9),
                new Worker("Georgi","Georgiev",450,8),
                new Worker("Ivailo","Petrov",200,7),
                new Worker("Anatoli","Nenov",360,9),
                new Worker("Sasho","Ivanov",320,5),
                new Worker("Borislav","Petkov",270,4)
            };

            var sortedWorkers = workers.OrderBy(x => -x.MoneyPerHour());

            //foreach (var item in sortedWorkers)
            //{
            //    Console.WriteLine(item);
            //}
            List<Human> humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);

            var sortedHumans = humans.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);
            foreach (var item in sortedHumans)
            {
                Console.WriteLine(item);
            }
        }
    }
}
