using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApplication
{
    
    public class ScheduleLogic
    {
        DBSchedule scheduleDB = new DBSchedule();

        public int GetShiftCountPerDay(string date, int department_id)
        {
            return scheduleDB.GetShiftCountByDay(date, department_id);
        }

        public List<Shift> GetShifts(string date, int department_id)
        {
            return scheduleDB.GetShifts(date, department_id);
        }

        public void DeleteShiftFromSchedule(int shiftId)
        {
            scheduleDB.DeleteShiftFromSchedule(shiftId);
        }
        
        public void AssignShift(int emp_id, string date, string time_frame, int dep_id)
        {
            scheduleDB.AssignShift(emp_id, date, time_frame, dep_id);
        }

        public void UpdateShift(string timeFrame, int emp_id, string date)
        {
            scheduleDB.UpdateShift(timeFrame, emp_id, date);
        }

        public List<Shift> GetShiftsOfEmployee(int employeeId)
        {
            return scheduleDB.GetShiftOfEmployee(employeeId);
        }

        public string selectedTimeFrame(bool morning, bool afternoon, bool evening) //Used in ScheduleAssignEmp, ScheduleEdit
        {
            if (morning && afternoon && evening)
            {
                return "MORNING-EVENING";
            }
            else if (morning && afternoon)
            {
                return "MORNING-AFTERNOON";
            }
            else if (afternoon && evening)
            {
                return "AFTERNOON-EVENING";
            }
            else if (morning && evening) //Employee cant have afternoon free if they work morning and evening
            {
                System.Windows.Forms.MessageBox.Show("Employee cannot have afternoon free while having been assigned morning and evening shifts");
                return "EVENING-MORNING";
            }
            else if (morning)
            {
                return "MORNING";
            }
            else if (afternoon)
            {
                return "AFTERNOON";
            }
            else if (evening)
            {
                return "EVENING";
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please pick a timeframe you would like to assign.");
                return "EVENING-MORNING";//easier if statement
            }
        }

        public string[] GetShiftPreferences(int employeeId) //Used for employeeView Unavailability comboboxes
        {
            return scheduleDB.GetShiftPreferences(employeeId);
        }

        public void SetShiftPreferences(int employeeId, string[] newDays)
        {
            string[] oldDays = GetShiftPreferences(employeeId);
            if (oldDays[0] == null)
            {
                scheduleDB.AddShiftPreference(employeeId, newDays);
            }
            else
            {
                scheduleDB.UpdateShiftPreference(employeeId, newDays);
            }
        }

        public int GetShiftCountByTimeFrame(string timeFrame, string date, int department_id)
        {
            return scheduleDB.GetShiftCountByTimeFrame(timeFrame, date, department_id);
        }

        public void AddHolidayRequest(int employeeId, string startDate, string endDate)
        {
            scheduleDB.AddHolidayRequest(employeeId, startDate, endDate, "pending");
        }

        public List<Holiday> GetAllHolidayRequests()
        {
            return scheduleDB.GetAllHolidayRequests();
        }

        public void RespondHolidayRequest(Holiday holiday)
        {
            scheduleDB.RespondHolidayRequest(holiday);
        }

        public Holiday GetHoliday(int employeeId)
        {
            return scheduleDB.GetHoliday(employeeId);
        }

        public void RequestHoliday(Holiday holiday)
        {
            scheduleDB.RequestHoliday(holiday);
        }

        public int GetShiftCountByDayWithValidEmployees(string date, int department_id)
        {
            return scheduleDB.GetShiftCountByDayWithValidEmployees(date, department_id);
        }
    }
}
