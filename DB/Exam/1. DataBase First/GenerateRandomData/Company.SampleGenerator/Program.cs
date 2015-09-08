namespace Company.SampleGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Company.Data;

    class Program
    {
        static void Main(string[] args)
        {
            var random = RandomGenerator.Instance;
            var db = new CompanyEntities();
            db.Configuration.AutoDetectChangesEnabled = false;

            var lisOfGenerators = new List<IDataGenerator>()
            {
                new ProjectDataGenerator(random,db,1000),
                new DepartmentDataGenerator(random,db,100),
                //new EmployeeDataGenerator(random,db, 5000)
                new ReportDataGenerator(random,db,25000)
            };

            foreach (var generator in lisOfGenerators)
            {
                generator.Generator();
                db.SaveChanges();
            }
        }
    }
}
