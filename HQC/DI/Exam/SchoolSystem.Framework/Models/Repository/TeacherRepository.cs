using SchoolSystem.Framework.Models.Contracts;
using System;
using System.Collections.Generic;

namespace SchoolSystem.Framework.Models.Repository
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly IDictionary<int, ITeacher> _teachers;

        public TeacherRepository()
        {
            this._teachers = new Dictionary<int, ITeacher>();
        }

        public void AddTeacher(int teacherId, ITeacher teacher)
        {
            this._teachers.Add(teacherId, teacher);
        }

        public void RemoveTeacher(int teacherId)
        {
            if (!this._teachers.ContainsKey(teacherId))
            {
                throw new ArgumentException("The given key was not present in the dictionary.");
            }

            this._teachers.Remove(teacherId);
        }

        public ITeacher GetTeacher(int teacherId)
        {
            return this._teachers[teacherId];
        }
    }
}
