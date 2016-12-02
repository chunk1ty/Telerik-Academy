using System;
using System.Collections.Generic;
using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.Models.Contracts;

namespace SchoolSystem.Framework.Core.Commands
{
    public class RemoveStudentCommand : ICommand
    {
        private readonly IStudentRepository _studentRepository;

        public RemoveStudentCommand(IStudentRepository schoolFactory)
        {
            this._studentRepository = schoolFactory;
        }

        public string Execute(IList<string> parameters)
        {
            var studentId = int.Parse(parameters[0]);
            this._studentRepository.RemoveStudent(studentId);
            return $"Student with ID {studentId} was sucessfully removed.";
        }
    }
}
