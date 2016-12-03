using SchoolSystem.Framework.Models.Contracts;
using SchoolSystem.Framework.Models.Enums;

namespace SchoolSystem.Framework.Core
{
    public interface ITeacherFactory
    {
        // because of the Ninject registration 
        // Kernel.Bind<ITeacherFactory>().ToFactory().InSingletonScope();
        // the name of parameters should be the same as in the Teacher.cs
        ITeacher CreateTeacher(string firstName, string lastName, Subject subject);        
    }
}
