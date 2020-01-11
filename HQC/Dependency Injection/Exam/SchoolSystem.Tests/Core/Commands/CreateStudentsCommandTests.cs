using Moq;
using NUnit.Framework;
using SchoolSystem.Framework.Core.Commands;
using SchoolSystem.Framework.Core.Contracts;
using SchoolSystem.Framework.Models.Contracts;
using SchoolSystem.Framework.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Tests.Core.Commands
{
    [TestFixture]
    public class CreateStudentsCommandTests
    {
        private static readonly string SuccessMessageTemplate = "A new student with name {0} {1}, grade {2} and ID {3} was created.";

        private const string SourcesListVariableName = "_sourceLists";

        private static object[] _sourceLists = {new object[] {new List<string> { "Pesho", "Petrov", "6" }}};       

        [Test, TestCaseSource(SourcesListVariableName)]
        public void Execute_WhenParametersAreValid_ShouldCreateNewStudent(IList<string> parameters)
        {
            // Arrange
            var firstName = parameters[0];
            var lastName = parameters[1];
            var grade = (Grade)int.Parse(parameters[2]);
            var mockStudentFactory = new Mock<IStudentFactory>();
            var mockAddStudent = new Mock<IAddStudent>();
            var createStudentCommand = new CreateStudentCommand(mockStudentFactory.Object, mockAddStudent.Object);

            // Act
            createStudentCommand.Execute(parameters);

            // Assert
            mockStudentFactory.Verify(x => x.CreateStudent(firstName, lastName, grade));
        }

        [Test, TestCaseSource(SourcesListVariableName)]
        public void Execute_WhenParametersAreValid_ShouldAddNewStudent(IList<string> parameters)
        {
            // Arrange
            var firstName = parameters[0];
            var lastName = parameters[1];
            var grade = (Grade)int.Parse(parameters[2]);

            var mockStudentFactory = new Mock<IStudentFactory>();
            var mockStudent = new Mock<IStudent>();
            mockStudentFactory.Setup(f => f.CreateStudent(firstName, lastName, grade)).Returns(mockStudent.Object);

            var mockAddStudent = new Mock<IAddStudent>();
            var createStudentCommand = new CreateStudentCommand(mockStudentFactory.Object, mockAddStudent.Object);

            // Act
            createStudentCommand.Execute(parameters);

            // Assert
            mockAddStudent.Verify(x => x.AddStudent(0, mockStudent.Object), Times.Once());
        }

        [Test, TestCaseSource(SourcesListVariableName)]
        public void Execute_WhenParametersAreValid_ReturnMessage(IList<string> parameters)
        {
            // Arrange
            var firstName = parameters[0];
            var lastName = parameters[1];
            var grade = (Grade)int.Parse(parameters[2]);
            var mockStudentFactory = new Mock<IStudentFactory>();
            var mockAddStudent = new Mock<IAddStudent>();
            var createStudentCommand = new CreateStudentCommand(mockStudentFactory.Object, mockAddStudent.Object);

            // Act
            var result = createStudentCommand.Execute(parameters);

            // Assert
            Assert.AreEqual(string.Format(SuccessMessageTemplate, firstName, lastName, grade, 0), result);
        }
    }
}
