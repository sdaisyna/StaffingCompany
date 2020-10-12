using StaffingCompany.Application.Model.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace StaffingCompany.Application.Service.Employee
{
    public interface IEmployeeService
    {
        dynamic GetAllEmployee();

        bool AddEmployee(MvEmployee employee);
        bool EditEmployee(MvEditEmployee employee);
    }
}
