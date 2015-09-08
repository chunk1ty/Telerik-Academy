namespace EfPerformance
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
            TelerikAcademyEntities db = new TelerikAcademyEntities();
            //PrintAllEmployeesQ1Problem(db);
            //PrintAllEmployeesWithoutQ1Problem(db);
            
            //SelectWithToList(db);
            SelectWithoutToList(db);
        }

        private static void PrintAllEmployeesWithoutQ1Problem(TelerikAcademyEntities db)
        {
            using (db)
            {
                foreach (var employee in db.Employees.Include("Department").Include("Address.Town"))
                {
                    Console.WriteLine("{0} {1} - {2} - {3}",
                        employee.FirstName,
                        employee.LastName,
                        employee.Department.Name,
                        employee.Address.Town.Name);
                }
            }
        }

        private static void PrintAllEmployeesQ1Problem(TelerikAcademyEntities db)
        {
            using(db)
            {
                foreach (var employee in db.Employees)
                {
                    Console.WriteLine("{0} {1} -  {2} {3} ",
                        employee.FirstName, 
                        employee.LastName,
                        employee.Department.Name,
                        employee.Address.Town.Name);
                }
            }
        }
        private static void SelectWithToList(TelerikAcademyEntities dbContext)
        {
            using (dbContext)
            {
                var employessInSofia = dbContext.Employees                                         
                                         .ToList()
                                         .Select(e => e.Address)
                                         .ToList()
                                         .Select(a => a.Town)
                                         .ToList()
                                         .Where(a => a.Name == "Sofia")
                                         .ToList();

                Console.WriteLine("Employees in Sofia count: " + employessInSofia.Count);
            }
        }

        private static void SelectWithoutToList(TelerikAcademyEntities dbContext)
        {
            using (dbContext)
            {
                var employessInSofia = dbContext.Employees
                                         .Select(e => e.Address)
                                         .Select(a => a.Town)
                                         .Where(a => a.Name == "Sofia")
                                         .ToList();

                Console.WriteLine("Employees in Sofia count: " + employessInSofia.Count);
            }
        }

    }
}
