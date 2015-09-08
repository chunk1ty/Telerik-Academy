namespace Company.SampleGenerator
{
    using Company.Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class EmployeeDataGenerator : DataGenerator, IDataGenerator
    {
        public EmployeeDataGenerator(IRandomGenerator randomGenerator, CompanyEntities db, int count)
            : base(randomGenerator, db, count)
        {
            
        }

        public override void Generator()
        {
            var departmentIds = this.DataBase.Departments.Select(d => d.Id).ToList();

            // 5000 are employees ;v uslovieto e taka
            var employeesWithManagers = this.Count * 0.95;
            var managers = this.Count - employeesWithManagers;

            Console.WriteLine("Adding employee");

            var allEmployeesWithManagers = new List<Employee>();

            for (int i = 0; i < employeesWithManagers; i++)
            {
                var employee = new Employee
                {
                    FirstName = this.Random.GetRandomStringWithRandomRange(5, 20),
                    LastName = this.Random.GetRandomStringWithRandomRange(5, 20),
                    YearSalary = this.Random.GetRandomNumber(50000, 200000),
                    DepartmentId = departmentIds[this.Random.GetRandomNumber(0, departmentIds.Count -1)]
                };
                allEmployeesWithManagers.Add(employee);

                this.DataBase.Employees.Add(employee);

                if (i % 100 == 0)
                {
                    this.DataBase.SaveChanges();
                }
            }

            for (int i = 0; i < managers; i++)
            {
                var employee = new Employee
                {
                    FirstName = this.Random.GetRandomStringWithRandomRange(5, 20),
                    LastName = this.Random.GetRandomStringWithRandomRange(5, 20),
                    YearSalary = this.Random.GetRandomNumber(50000, 200000),
                    DepartmentId = departmentIds[this.Random.GetRandomNumber(0, departmentIds.Count - 1)],
                    Employee1 = allEmployeesWithManagers[this.Random.GetRandomNumber(0,allEmployeesWithManagers.Count -1)],
                };

                this.DataBase.Employees.Add(employee);

                if (i % 100 == 0)
                {
                    this.DataBase.SaveChanges();
                }
            }

            this.DataBase.SaveChanges();
            
        }
    }
}
