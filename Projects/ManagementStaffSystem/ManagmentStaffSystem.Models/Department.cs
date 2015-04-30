namespace ManagmentStaffSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Department
    {
        private ICollection<Servant> servants;

        public Department()
        {
            this.Servants = new HashSet<Servant>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        [Display(Name = "Department")]
        public string DepartmentName { get; set; }

        public virtual ICollection<Servant> Servants
        {
            get
            {
                return this.servants;
            }
            set
            {
                this.servants = value;
            }
        }
    }
}