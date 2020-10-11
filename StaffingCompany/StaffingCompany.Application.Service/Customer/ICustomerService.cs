
using StaffingCompany.Application.Model.Customer;
using System;
using System.Collections.Generic;
using System.Text;

namespace StaffingCompany.Application.Service.Customer
{
    public interface ICustomerService
    {
        dynamic GetAllCustomer();

        bool AddCustomer(MvCustomer customer);
        bool EditCustomer(MvEditCustomer customer);
    }
}
