namespace ManagementStaffSystem.Data
{
    using ManagementStaffSystem.Data.Repositories;
    using ManagmentStaffSystem.Models;

    public interface IManagementStaffSystemData
    {
        IGenericRepository<Department> Departments { get; }

        IGenericRepository<Servant> Servants { get; }

        void SaveChanges();
    }
}
