using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectStateValidator.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student
            {
                FristName = "Andriyan",
                LastName = "Krastev",
                Age = 22,
                Marks = new List<int> { 2, 2},
                Mentor = new Student
                {
                    //FristName = "Ivaylo",
                    //LastName = "Ivanov",
                    Age = 17,
                    Marks = new List<int> { 3, 4, 5,6}
                }
            };

            var studentValidator = new Validator(student);
            studentValidator.Validate();
            if (!studentValidator.Isvalid)
            {
                foreach (var error in studentValidator.Errors)
                {
                    Console.WriteLine(error.Key);
                }
            }
        }
    }
}
