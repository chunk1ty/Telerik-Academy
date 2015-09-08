namespace Company.SampleGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Company.Data;

    internal abstract class DataGenerator : IDataGenerator
    {
        private IRandomGenerator random;
        private CompanyEntities db;
        private int count;

        public DataGenerator(IRandomGenerator randomDataGenerator, CompanyEntities db, int count)
        {
            this.random = randomDataGenerator;
            this.db = db;
            this.count = count;
        }

        protected IRandomGenerator Random
        {
            get
            {
                return this.random;
            }
        }

        protected CompanyEntities DataBase
        {
            get
            {
                return this.db;
            }
        }

        protected int Count
        {
            get
            {
                return this.count;
            }
        }

        public abstract void Generator();        
    }
}
