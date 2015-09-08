using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Scaffolding.Models;

namespace Scaffolding.InputModels
{
    public class StudentInputModel
    {
        [Display(Name = "Цяло име")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is required!")]
        public string FullName { get; set; }

        [Range(2, 6, ErrorMessage = "{0} should be between {1} and {2}")]
        public int Grade { get; set; }

        [StringLength(20, MinimumLength = 5, ErrorMessage = "{0} should be between {2} and {1}")]
        public string FacultyNumber { get; set; }

        public Address Address { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}