using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StaffingCompany.Application.Model.Employee
{
    public class MvEmployee
    {
        [Required]
        public string firstName { get; set; }

        public string middleName { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        public string city { get; set; }
        [Required]
        public string state { get; set; }
        [Required]
        public string zipCode { get; set; }
        [Required]
        public string emailAddress { get; set; }
        [Required]
        public string phoneNumber { get; set; }
    }

    public class MvEditEmployee
    {
        [Required]
        public int personId { get; set; }

        [Required]
        public string firstName { get; set; }

        public string middleName { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        public string city { get; set; }
        [Required]
        public string state { get; set; }
        [Required]
        public string zipCode { get; set; }
        [Required]
        public string emailAddress { get; set; }
        [Required]
        public string phoneNumber { get; set; }

    }
}
