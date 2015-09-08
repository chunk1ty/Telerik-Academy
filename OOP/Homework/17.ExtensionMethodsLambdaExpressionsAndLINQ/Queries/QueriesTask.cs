namespace Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class QueriesTask
    {
        static void Main()
        {
            List<Student> listOfStudent = new List<Student>
            {
               new Student("Andriyan","Krastev",113206,"1234561","aank@abv.bg",new List<int>{3,4,5,6,},1),
               new Student("Zornica","Krasteva",113251,"021234562","bank@ank.bg",new List<int>{3,2},1),
               new Student("Boris","Atanasov",113252,"1234563","cank@ank.bg",new List<int>{3,4,5,6,6,6},2),
               new Student("Ivan","Todorov",113253,"1234564","dank@abv.bg",new List<int>{3,4,5,6,2,3},2),
               new Student("bai Gosho","abe nema",113254,"021234565","eank@ank.bg",new List<int>{3,4,5,5,4},3),
               new Student("Ivo","Ivov",113255,"1234566","fank@abv.bg",new List<int>{2,2},3),
            };         

            var firstNameBeforeLastName = listOfStudent.Where(st => st.FirstName.CompareTo(st.LastName) < 0);
            //Print(firstNameBeforeLastName);

            //var studentsBetween18And24 = listOfStudent.Where(st => st.Age >= 18 && st.Age <= 24);
            //Print(studentsBetween18And24);

            var sortedByName =
                listOfStudent
                .OrderByDescending(st => st.FirstName)
                .ThenBy(st => st.LastName);
            //Print(sortedByName);
            
            //9 LINQ query
            var groupNumber2 =
                from st in listOfStudent
                where st.GroupNumber == 2
                orderby st.FirstName
                select st;

            //foreach (var item in groupNumber2)
            //{
            //    Console.WriteLine(item);
            //}
            //10 Lambda expression
            var groupName2Lambda =
                listOfStudent
                .Where(st => st.GroupNumber == 2)
                .OrderBy(st => st.FirstName);
            //Print(groupName2Lambda);

            //11
            var studWithEmailAbvBG =
                from st in listOfStudent
                where st.Email.EndsWith("abv.bg")
                select st;
            //foreach (var item in studWithEmailAbvBG)
            //{
            //    Console.WriteLine(item);
            //}

            //12
            var studWithSofiaNumber =
                from st in listOfStudent
                where st.Tel.StartsWith("02")
                select st;
            //foreach (var item in studWithSofiaNumber)
            //{
            //    Console.WriteLine(item);
            //}

            //13
            var studWithOneOrMore6 =
                from st in listOfStudent
                where st.Mark.Contains(6)
                select st;
            //foreach (var item in studWithOneOrMore6)
            //{
            //    Console.WriteLine(item);
            //}

            //14
            var studWithTwoMark = listOfStudent.Where(st => st.Mark.Count(m => m == 2) == 2);
            Print(studWithTwoMark);


        }      

        public static void Print(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }       
    }
}
