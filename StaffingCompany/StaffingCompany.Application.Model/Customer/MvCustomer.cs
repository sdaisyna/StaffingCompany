using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StaffingCompany.Application.Model.Customer
{
    public class MvCustomer
    {
       [Required]
        public string organizationName { get; set; }
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

    public class MvEditCustomer
    {
        [Required]
        public int organizationId {get; set;}
        [Required]
        public string organizationName { get; set; }
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
