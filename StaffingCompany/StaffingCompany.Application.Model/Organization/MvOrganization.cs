using System;
using System.Collections.Generic;
using System.Text;

namespace StaffingCompany.Application.Model.Organization
{
    public class MvOrganization
    {
        public string organizationName { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipCode { get; set; }
        public string emailAddress { get; set; }
        public string phoneNumber { get; set; }
    }
}
