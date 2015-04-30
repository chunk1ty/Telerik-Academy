namespace ManagementStaffSystem.Data
{
    using ManagementStaffSystem.Data.Repositories;
    using ManagmentStaffSystem.Models;
    using System;
    using System.Collections.Generic;

    public class ManagementStaffSystemData : IManagementStaffSystemData
    {
        private IManagementStaffSystemDbContext context;
        private IDictionary<Type, object> repositories;

        public ManagementStaffSystemData(IManagementStaffSystemDbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public ManagementStaffSystemData()
            : this(new ManagementStaffSystemDbContext())
        {
        }

        public IGenericRepository<Department> Departments
        {
            get 
            {
                return this.GetRepository<Department>();
            }
        }

        public IGenericRepository<Servant> Servants
        {
            get
            {
                return this.GetRepository<Servant>();
            }
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }

        private IGenericRepository<T> GetRepository<T>() where T : class
        {
            var typeOfModel = typeof(T);
            if (!this.repositories.ContainsKey(typeOfModel))
            {
                var type = typeof(GenericRepository<T>);

                this.repositories.Add(typeOfModel, Activator.CreateInstance(type, this.context));
            }

            return (IGenericRepository<T>)this.repositories[typeOfModel];
        }
    }
}