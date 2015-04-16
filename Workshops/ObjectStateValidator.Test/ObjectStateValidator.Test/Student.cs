namespace ObjectStateValidator.Test
{
    using ObjectStateValidator.Anotations;
    using System.Collections.Generic;

    public class Student
    {
        public string FristName { get; set; }

        [Mandatory]
        public string LastName { get; set; }

        [Range(0, 100)]
        public int Age { get; set; }

        [Elements(4)]
        public ICollection<int> Marks { get; set; }
                
        public Student Mentor { get; set; }
    }
}
