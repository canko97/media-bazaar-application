using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarApplication
{
    public class Shift
    {
        //variables
        private int shiftId;
        private int employeeId;
        private DateTime shiftDate;
        private string timeFrame;
        private int department_id;

        public Shift(int shiftId, int employeeId, DateTime shiftDate, string timeFrame,int department_id)
        {
            this.ShiftId = shiftId;
            this.EmployeeId = employeeId;
            this.ShiftDate = shiftDate;
            this.TimeFrame = timeFrame;
            this.DepartmentId = department_id;
        }

        public Shift(DateTime shiftDate, string timeFrame)
        {
            this.ShiftDate = shiftDate;
            this.TimeFrame = timeFrame;
        }

        public int ShiftId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime ShiftDate { get; set; }
        public string TimeFrame { get; set; }
        public int DepartmentId { get; set; }
        


    }

}
