using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMP.Entities;
using EMP.Repositories.Data;
using EMP.Repositories.Interfaces;

namespace EMP.Repositories.Repositories
{
    public class LeaveApplicationRepository
        : ILeaveApplicationRepository
    {
        private readonly ApplicationDbContext _context;

        public LeaveApplicationRepository(
            ApplicationDbContext context)
        {
            _context = context;
        }

        public List<LeaveApplication> GetAll()
        {
            return _context.LeaveApplications.ToList();
        }

        public LeaveApplication? GetById(int id)
        {
            return _context.LeaveApplications
                .FirstOrDefault(l =>
                    l.LeaveApplicationId == id);
        }

        public List<LeaveApplication> GetByEmployeeId(
            int employeeId)
        {
            return _context.LeaveApplications
                .Where(l => l.EmployeeId == employeeId)
                .ToList();
        }

        public void Add(LeaveApplication leaveApplication)
        {
            _context.LeaveApplications.Add(
                leaveApplication);

            _context.SaveChanges();
        }

        public void Update(
            LeaveApplication leaveApplication)
        {
            _context.LeaveApplications.Update(
                leaveApplication);

            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var leaveApplication = GetById(id);

            if (leaveApplication != null)
            {
                _context.LeaveApplications.Remove(
                    leaveApplication);

                _context.SaveChanges();
            }
        }
    }
}