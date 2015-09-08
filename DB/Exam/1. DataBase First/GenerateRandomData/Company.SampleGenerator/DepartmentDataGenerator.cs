namespace Company.SampleGenerator
{
    using System;
    using Company.Data;
    using System.Collections.Generic;

    internal class DepartmentDataGenerator : DataGenerator, IDataGenerator
    {

        public DepartmentDataGenerator(IRandomGenerator randomGenerator, CompanyEntities db, int count)
            : base(randomGenerator, db, count)
        {
            
        }

        public override void Generator()
        {
            var uniqueDepartmentNames = new HashSet<string>();

            while (uniqueDepartmentNames.Count != this.Count)
            {
                var currentDepartmentName = this.Random.GetRandomStringWithRandomRange(10, 50);
                uniqueDepartmentNames.Add(currentDepartmentName);
            }

            int index = 0;
            Console.WriteLine("Adding Departments");
            foreach (string name in uniqueDepartmentNames)
            {
                var departament = new Department
                {
                    Name = name
                };

                this.DataBase.Departments.Add(departament);

                index++;

                if (index % 100 == 0)
                {
                    this.DataBase.SaveChanges();
                }
            }


            Console.WriteLine("Departments added");            
        }
    }
}
