using System.Collections.Generic;
using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.Models.Contracts;

namespace SchoolSystem.Framework.Core.Commands
{
    public class StudentListMarksCommand : ICommand
    {
        private readonly IStudentRepository _studentRepository;

        public StudentListMarksCommand(IStudentRepository studentRepository)
        {
            this._studentRepository = studentRepository;
        }

        public string Execute(IList<string> parameters)
        {
            var studentId = int.Parse(parameters[0]);
            var student = this._studentRepository.GetStudent(studentId);

            return student.ListMarks();
        }
    }
}
