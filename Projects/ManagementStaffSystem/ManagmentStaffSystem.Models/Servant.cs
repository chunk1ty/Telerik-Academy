namespace ManagmentStaffSystem.Models
{
    using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

    public class Servant
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Egn")]
        public int Egn { get; set; }

        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
    }
}