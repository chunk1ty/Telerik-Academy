using SchoolSystem.Framework.Models.Contracts;
using SchoolSystem.Framework.Models.Enums;

namespace SchoolSystem.Framework.Core
{
    public interface IStudentFactory
    {
        // Do not name it GetStudent (Get is a key word in Ninject)
        // because of the Ninject registration 
        // var studentFactoryBinding = Kernel.Bind<IStudentFactory>().ToFactory().InSingletonScope();
        // the name of parameters should be the same as in the Student.cs
        IStudent CreateStudent(string firstName, string lastName, Grade grade);
    }
}
