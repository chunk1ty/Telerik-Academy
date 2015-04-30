namespace ManagementStaffSystem.Data
{
    using System.Data.Entity.Infrastructure;
    using ManagmentStaffSystem.Models;
    using System.Data.Entity;
    using ManagementStaffSystem.Data.Migrations;

    public class ManagementStaffSystemDbContext : DbContext ,IManagementStaffSystemDbContext
    {
        public ManagementStaffSystemDbContext()
            : base ("ManagementStaffSystemConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ManagementStaffSystemDbContext, Configuration>());
        }

        public IDbSet<Department> Departments { get; set; }

        public IDbSet<Servant> Servants { get; set; }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }
    }
}