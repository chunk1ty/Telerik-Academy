﻿namespace ManagementStaffSystem.Data
{
    using ManagmentStaffSystem.Models;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public interface IManagementStaffSystemDbContext
    {
        IDbSet<Department> Departments { get; set; }

        IDbSet<Servant> Servants { get; set; }

        IDbSet<T> Set<T>() where T : class;

        DbEntityEntry<T> Entry<T>(T entity) where T : class;

        void SaveChanges();
    }
}