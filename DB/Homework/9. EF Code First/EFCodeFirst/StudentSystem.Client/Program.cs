namespace StudentsSystem.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;    
    using StudentsSystem.Data;
    using System.Data.Entity;
    using StudentSystem.Data.Migrations;
    using StudentsSystem.Models;

    public class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentsSystemContext, Configuration>());

            using (var db = new StudentsSystemContext())
            {
                Console.WriteLine("Students:");
                foreach (var student in db.Students)
                {
                    Console.WriteLine(student.StudentId + ": " + student.Name + " has number " + student.Number);
                }

                Console.WriteLine("Courses:");
                foreach (var course in db.Courses)
                {
                    Console.WriteLine(course.CourseId + ": " + course.Name + " has description " +
                        course.Description + " and needs materials: " + course.Materials);
                }
            }
        }
    }
}
