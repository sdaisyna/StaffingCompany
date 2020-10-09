
using StaffingCompany.Application.Model.Organization;
using System;
using System.Collections.Generic;
using System.Text;

namespace StaffingCompany.Application.Service.Organization
{
    public interface IOrganizationService
    {
        dynamic GetAllOrganization();

        bool AddOrganization(MvOrganization organization);
    }
}
