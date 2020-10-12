using StaffingCompany.Application.Model.Job;
using System;
using System.Collections.Generic;
using System.Text;

namespace StaffingCompany.Application.Service.Job
{
    public interface IJobService
    {
        dynamic GetJobDetail();
        bool AddJob(MvJob job);
        bool EditJob(MvEditJob job);
    }
}
