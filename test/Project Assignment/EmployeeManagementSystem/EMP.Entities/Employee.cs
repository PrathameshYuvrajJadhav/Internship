 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMP.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string FullName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public int BranchId { get; set; }

        public int DepartmentId { get; set; }

        public DateTime JoiningDate { get; set; }
    }
}