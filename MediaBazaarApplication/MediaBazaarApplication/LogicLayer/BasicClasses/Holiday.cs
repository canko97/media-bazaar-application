using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApplication
{
    public class Holiday
    {

        private int employeeId;
        private string startDate;
        private string endDate;

        public Holiday(int employeeId, string startDate, string endDate, string status)
        {
            this.employeeId = employeeId;
            this.startDate = startDate;
            this.endDate = endDate;
            this.Status = status;
        }

        public int GetEmployeeId()
        {
            return employeeId;
        }

        public string GetStartDate()
        {
            return startDate;
        }

        public string GetEndDate()
        {
            return endDate;
        }

        public string Status { get; set; }


    }
}
