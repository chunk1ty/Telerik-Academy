using Company.Data;
using System;
using System.Linq;

namespace Company.SampleGenerator
{
    internal class ReportDataGenerator : DataGenerator, IDataGenerator
    {
        public ReportDataGenerator(IRandomGenerator randomGenerator, CompanyEntities db, int count)
            : base(randomGenerator, db, count)
        {

        }

        public override void Generator()
        {
            var employees = this.DataBase.Employees.Select(e => e.Id).ToList();

            for (int i = 0; i < this.Count; i++)
            {
                var report = new Report
                {
                    Time = new DateTime(this.Random.GetRandomNumber(2001, 20015), this.Random.GetRandomNumber(1, 12), this.Random.GetRandomNumber(1, 24)),
                    EmployeeId = employees[this.Random.GetRandomNumber(0, employees.Count - 1)]
                };

                this.DataBase.Reports.Add(report);

                if (i % 100 == 0)
                {
                    Console.Write(".");
                    this.DataBase.SaveChanges();
                }
            }
        }
    }
}
