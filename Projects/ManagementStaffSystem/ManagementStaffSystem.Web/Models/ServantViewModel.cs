using ManagmentStaffSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ManagementStaffSystem.Web.Models
{
    public class ServantViewModel
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "EGN")]
        public int Egn { get; set; }
        
        public int DepartmentId { get; set; }

        [Display(Name = "Department")]
        public int DepartmentName { get; set; }

        public virtual Department Department { get; set; }

        //public virtual ICollection<Department> Departments { get; set; }
    }
}