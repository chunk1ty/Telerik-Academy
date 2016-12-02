using SchoolSystem.Framework.Models.Contracts;
using SchoolSystem.Framework.Models.Enums;

namespace SchoolSystem.Framework.Core
{
    public interface IStudentFactory
    {
        // Do not name it GetStudent (Get is a key word in Ninject)
        IStudent CreateStudent(string firstName, string lastName, Grade grade);
    }
}
