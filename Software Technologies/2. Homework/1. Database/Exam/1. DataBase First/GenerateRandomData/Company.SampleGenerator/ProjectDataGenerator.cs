namespace Company.SampleGenerator
{
    using Company.Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class ProjectDataGenerator : DataGenerator, IDataGenerator
    {
        public ProjectDataGenerator(IRandomGenerator randomGenerator, CompanyEntities db, int count)
            : base(randomGenerator, db, count)
        {
            
        }

        public override void Generator()
        {
            Console.WriteLine("Adding Projects");
            for (int i = 0; i < this.Count; i++)
            {
                var project = new Project
                {
                    Name = this.Random.GetRandomStringWithRandomRange(5, 50)
                };

                this.DataBase.Projects.Add(project);

                if (i % 100 == 0)
                {
                    this.DataBase.SaveChanges();
                }
            }

            Console.WriteLine("Projects added");
        }
    }
}
