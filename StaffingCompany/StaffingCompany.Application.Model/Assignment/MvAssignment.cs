using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StaffingCompany.Application.Model.Assignment
{
    public class MvAssignment
    {
        [Required]
        public string jobId { get; set; }
        [Required]
        public string employeeId { get; set; }
        [Required]
        public string customerId { get; set; }

    }

    public class MvEditAssignment
    {
        [Required]
        public string assignmentId { get; set; }
        [Required]
        public string jobId { get; set; }
        [Required]
        public string employeeId { get; set; }
        [Required]
        public string customerId { get; set; }

    }



}
