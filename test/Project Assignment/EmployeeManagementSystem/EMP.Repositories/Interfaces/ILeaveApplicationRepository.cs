using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMP.Entities;

namespace EMP.Repositories.Interfaces
{
    public interface ILeaveApplicationRepository
    {
        List<LeaveApplication> GetAll();

        LeaveApplication? GetById(int id);

        List<LeaveApplication> GetByEmployeeId(int employeeId);

        void Add(LeaveApplication leaveApplication);

        void Update(LeaveApplication leaveApplication);

        void Delete(int id);
    }
}