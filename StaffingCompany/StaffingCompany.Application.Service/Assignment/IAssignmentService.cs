using StaffingCompany.Application.Model.Assignment;
using System;
using System.Collections.Generic;
using System.Text;

namespace StaffingCompany.Application.Service.Assignment
{
    public interface IAssignmentService
    {
        dynamic GetAssignmentDetail();

        bool AddAssignment(MvAssignment assignment);
        bool EditAssignment(MvEditAssignment assignment);
    }
}
