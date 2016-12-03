using SchoolSystem.Framework.Models.Contracts;
using System;
using System.Collections.Generic;

namespace SchoolSystem.Framework.Models.Repository
{
    public class StudentLocalRepository : IStudentRepository
    {
        private readonly IDictionary<int, IStudent> _students;

        public StudentLocalRepository()
        {
            this._students = new Dictionary<int, IStudent>();
        }

        public void AddStudent(int studentId, IStudent student)
        {
            this._students.Add(studentId, student);
        }

        public void RemoveStudent(int studentId)
        {
            if (!this._students.ContainsKey(studentId))
            {
                throw new ArgumentException("The given key was not present in the dictionary.");
            }

            this._students.Remove(studentId);
        }

        public IStudent GetStudent(int studentId)
        {
            return this._students[studentId];
        }
    }
}
