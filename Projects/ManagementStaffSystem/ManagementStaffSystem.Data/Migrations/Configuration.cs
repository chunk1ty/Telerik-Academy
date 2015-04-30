namespace ManagementStaffSystem.Data.Migrations
{
    using ManagmentStaffSystem.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<ManagementStaffSystem.Data.ManagementStaffSystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ManagementStaffSystem.Data.ManagementStaffSystemDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Departments.AddOrUpdate(
                d => d.DepartmentName,
                new Department { DepartmentName = "Department 1" },
                new Department { DepartmentName = "Department 2" },
                new Department { DepartmentName = "Department 3" },
                new Department { DepartmentName = "Department 4" },
                new Department { DepartmentName = "Department 5" },
                new Department { DepartmentName = "Department 6" });

            context.Servants.AddOrUpdate(
                new Servant
                {
                    FirstName = "FirstName1",
                    LastName = "LastName1",
                    Egn = 123,
                    DepartmentId = 1
                },
                new Servant
                {
                    FirstName = "FirstName2",
                    LastName = "LastName2",
                    Egn = 124,
                    DepartmentId = 2
                },
                new Servant
                {
                    FirstName = "FirstName3",
                    LastName = "LastName3",
                    Egn = 1231,
                    DepartmentId = 5
                },
                new Servant
                {
                    FirstName = "FirstName6",
                    LastName = "LastName7",
                    Egn = 123111,
                    DepartmentId = 5
                });
        }
    }
}
