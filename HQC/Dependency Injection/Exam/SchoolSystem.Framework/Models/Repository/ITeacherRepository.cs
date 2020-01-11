namespace SchoolSystem.Framework.Models.Contracts
{
    public interface ITeacherRepository
    {
        void AddTeacher(int teacherId, ITeacher teacher);

        void RemoveTeacher(int teacherId);

        ITeacher GetTeacher(int teacherId);
    }
}
