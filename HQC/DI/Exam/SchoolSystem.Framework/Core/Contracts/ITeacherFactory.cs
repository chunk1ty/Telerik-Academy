using SchoolSystem.Framework.Models.Contracts;
using SchoolSystem.Framework.Models.Enums;

namespace SchoolSystem.Framework.Core
{
    public interface ITeacherFactory
    {
        ITeacher CreateTeacher(string firstName, string lastName, Subject subject);        
    }
}
