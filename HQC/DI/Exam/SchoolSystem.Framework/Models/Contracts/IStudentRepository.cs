namespace SchoolSystem.Framework.Models.Contracts
{
    public interface IStudentRepository
    {
        void AddStudent(int studentId, IStudent student);

        void RemoveStudent(int studentId);

        IStudent GetStudent(int studentId);
    }
}
