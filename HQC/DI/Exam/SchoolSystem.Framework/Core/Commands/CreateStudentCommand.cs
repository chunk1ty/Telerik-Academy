using System.Collections.Generic;
using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.Models.Enums;
using SchoolSystem.Framework.Models.Contracts;

namespace SchoolSystem.Framework.Core.Commands
{
    public class CreateStudentCommand : ICommand
    {
        private int currentStudentId = 0;

        private readonly IStudentFactory _studentFactory;
        private readonly IStudentRepository _studentRepository;

        public CreateStudentCommand(IStudentFactory schoolFactory, IStudentRepository studentRepository)
        {
            this._studentFactory = schoolFactory;
            this._studentRepository = studentRepository;
        }

        public string Execute(IList<string> parameters)
        {
            var firstName = parameters[0];
            var lastName = parameters[1];
            var grade = (Grade)int.Parse(parameters[2]);

            var student = _studentFactory.CreateStudent(firstName, lastName, grade);
            this._studentRepository.AddStudent(currentStudentId, student);

            return $"A new student with name {firstName} {lastName}, grade {grade} and ID {currentStudentId++} was created.";
        }
    }
}
