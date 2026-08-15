using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMP.Entities
{
    public class LeaveApplication
    {
        public int LeaveApplicationId { get; set; }

        public int EmployeeId { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public string Reason { get; set; } = string.Empty;

        public string Status { get; set; } = "Pending";

        public DateTime AppliedDate { get; set; } = DateTime.Now;
    }
}
