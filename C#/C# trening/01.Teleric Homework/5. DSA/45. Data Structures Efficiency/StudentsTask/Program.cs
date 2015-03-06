namespace StudentsTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<Student>> courses = new SortedDictionary<string, List<Student>>();
            StreamReader reader = new StreamReader(@"students.txt",Encoding.GetEncoding("windows-1251"));

            using (reader)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    string[] data = line.Split(new char[] {' ', '|' }, StringSplitOptions.RemoveEmptyEntries);
                    Student student = new Student(data[0], data[1]);

                    if (courses.ContainsKey(data[2]))
                    {
                        courses[data[2]].Add(student);
                    }
                    else
                    {
                        courses.Add(data[2], new List<Student>() { student });
                    }

                    line = reader.ReadLine();
                }
            }

            foreach (var element in courses)
            {
                Console.Write(element.Key + ":");
                var sortedStudents = element.Value.OrderBy(x => x.LastName).ThenBy(y => y.FirstName);
                foreach (var student in sortedStudents)
                {
                    Console.Write(student.ToString() + " ");
                }

                Console.WriteLine();
               
            }
        }
    }
}
