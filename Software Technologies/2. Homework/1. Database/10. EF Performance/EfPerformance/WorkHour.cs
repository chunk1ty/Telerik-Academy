//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EfPerformance
{
    using System;
    using System.Collections.Generic;
    
    public partial class WorkHour
    {
        public int WorkReportId { get; set; }
        public int EmployeeId { get; set; }
        public System.DateTime OnDate { get; set; }
        public string Task { get; set; }
        public int Hours { get; set; }
        public string Comments { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
