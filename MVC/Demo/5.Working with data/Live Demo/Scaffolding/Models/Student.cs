using System.ComponentModel.DataAnnotations;

namespace Scaffolding.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }
        [Range(2, 6)]
        public int Grade { get; set; }

        [StringLength(20, MinimumLength = 5)]
        public string FacultyNumber { get; set; }

        public Address Address { get; set; }
    }
}