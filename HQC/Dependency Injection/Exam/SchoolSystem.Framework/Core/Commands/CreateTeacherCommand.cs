using System.Collections.Generic;

using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.Models;
using SchoolSystem.Framework.Models.Enums;
using SchoolSystem.Framework.Models.Contracts;

namespace SchoolSystem.Framework.Core.Commands
{
    public class CreateTeacherCommand : ICommand
    {
        private int currentTeacherId = 0;

        private readonly ITeacherFactory _teacherFactory;
        private readonly ITeacherRepository _teacherRepository;

        public CreateTeacherCommand(ITeacherFactory schoolFactory, ITeacherRepository teacherRepository)
        {
            this._teacherFactory = schoolFactory;
            this._teacherRepository = teacherRepository;
        }

        public string Execute(IList<string> parameters)
        {
            var firstName = parameters[0];
            var lastName = parameters[1];
            var subject = (Subject)int.Parse(parameters[2]);

            var teacher = _teacherFactory.CreateTeacher(firstName, lastName, subject);
            this._teacherRepository.AddTeacher(currentTeacherId, teacher);

            return $"A new teacher with name {firstName} {lastName}, subject {subject} and ID {currentTeacherId++} was created.";
        }
    }
}
