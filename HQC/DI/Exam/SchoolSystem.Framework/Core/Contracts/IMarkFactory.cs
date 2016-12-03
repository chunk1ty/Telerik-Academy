using SchoolSystem.Framework.Models.Contracts;
using SchoolSystem.Framework.Models.Enums;

namespace SchoolSystem.Framework.Core
{
    public interface IMarkFactory
    {
        // because of the Ninject registration 
        // var markFactoryBinding = Kernel.Bind<IMarkFactory>().ToFactory().InSingletonScope();
        // the name of parameters should be the same as in the Mark.cs
        IMark CreateMark(Subject subject, float value);
    }
}
