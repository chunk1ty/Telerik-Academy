using System;

using SchoolSystem.Framework.Models.Abstractions;
using SchoolSystem.Framework.Models.Contracts;
using SchoolSystem.Framework.Models.Enums;
using SchoolSystem.Framework.Core;

namespace SchoolSystem.Framework.Models
{
    public class Teacher : Person, ITeacher
    {
        public const int MaxStudentMarksCount = 20;

        private readonly IMarkFactory _markFactory;

        public Teacher(string firstName, string lastName, Subject subject, IMarkFactory schoolFactory)
            : base(firstName, lastName)
        {
            this.Subject = subject;
            this._markFactory = schoolFactory;
        }

        public Subject Subject { get; set; }

        public void AddMark(IStudent student, float mark)
        {
            if (student.Marks.Count >= MaxStudentMarksCount)
            {
                throw new ArgumentException($"The student's marks count exceed the maximum count of {MaxStudentMarksCount} marks");
            }

            var newMark = this._markFactory.CreateMark(this.Subject, mark);
            student.Marks.Add(newMark);
        }
    }
}
