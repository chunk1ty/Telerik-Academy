using SchoolSystem.Framework.Models.Contracts;
using SchoolSystem.Framework.Models.Enums;

namespace SchoolSystem.Framework.Core
{
    public interface IMarkFactory
    {       
        IMark CreateMark(Subject subject, float valuet);
    }
}
