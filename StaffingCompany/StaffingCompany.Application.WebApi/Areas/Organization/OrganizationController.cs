using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StaffingCompany.Application.Service.Organization;
using StaffingCompany.Application.WebApi.Areas.Base;

namespace StaffingCompany.Application.WebApi.Areas.Organization
{
    public class OrganizationController : BaseController
    {
        private IOrganizationService _organizationService;

        public OrganizationController(IOrganizationService organizationService)
        {
            _organizationService = organizationService;
        }
        [HttpGet]
        public IActionResult OrganizationDetail()
        {
            try
            {
                dynamic jsonString = _organizationService.GetAllOrganization();
                return Ok(jsonString);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
