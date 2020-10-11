using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StaffingCompany.Application.Model.Customer;
using StaffingCompany.Application.Service.Customer;
using StaffingCompany.Application.WebApi.Areas.Base;

namespace StaffingCompany.Application.WebApi.Areas.Customer
{
    public class CustomerController : BaseController
    {
        private ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        public IActionResult CustomerDetail()
        {
            try
            {
                dynamic jsonString = _customerService.GetAllCustomer();
                return Ok(jsonString);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public IActionResult AddCustomer([FromBody] MvCustomer customer)
        {
            try
            {
                var added = _customerService.AddCustomer(customer);
                if(!added)
                {
                    return BadRequest();
                }
                return Ok();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public IActionResult EditCustomer([FromBody] MvEditCustomer customer)
        {
            try
            {
                var edited = _customerService.EditCustomer(customer);
                if(!edited)
                {
                    return BadRequest();
                }
                return Ok();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
