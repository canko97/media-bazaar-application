using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net.Mail;



namespace MediaBazaarApplication
{
    public class EmployeesLogic
    {
        DBEmployees employeeDB = new DBEmployees();
        

        //Mail
        private string hostEmail = "mbgroup.bruh@gmail.com";
        private string hostPassword = "GroupBruh";

        public void SendEmail(string employeeMail, string password)
        {
            MailMessage mail = new MailMessage(hostEmail, employeeMail, "Credentials", $"Welcome to MediaBazaar, your password to log in the system is: {password}");
            SmtpClient host = new SmtpClient("smtp.gmail.com");
            host.Port = 587;
            host.Credentials = new System.Net.NetworkCredential(hostEmail, hostPassword);
            host.EnableSsl = true;
            host.Send(mail);
        }

        public string GeneratePassword()
        {
            int minLength = 8;
            int maxLength = 12;

            string potentialCharacters = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM1234567890.";

            StringBuilder generatedPassword = new StringBuilder();
            Random random = new Random();

            int passwordLength = random.Next(minLength, maxLength+1);

            while(passwordLength-- > 0)
            {
                generatedPassword.Append(potentialCharacters[random.Next(potentialCharacters.Length)]);
            }

            return generatedPassword.ToString();
        }

        public List<Employee> GetEmployeeGridList(string statusFilter)
        {
            return employeeDB.GetEmployeesByStatus(statusFilter); //Get employees by cbFilter value
        }

        public List<string> GetRoles()
        {
            return employeeDB.GetRoles();
        }

        public List<Employee> GetAvailableEmployees(int departmentId, string date)
        {
            return employeeDB.GetAvailableEmployees(departmentId, date);
        }

        public string GetNameById(int employeeId)
        {
            return employeeDB.GetNameById(employeeId);
        }

        public List<Employee> SearchEmployeeByLastName(string lastname, string statusFilter)
        {
            lastname = lastname.ToLower();
            List<Employee> employees = new List<Employee>();
            foreach (Employee emp in employeeDB.GetEmployeesByStatus(statusFilter))
            {
                string comparedLastName = emp.LastName.ToLower();
                if (comparedLastName.Contains(lastname))
                {
                    employees.Add(emp);
                }
            }
            return employees;
        }

        public void AddEmployee(string first_name, string last_name, string email, string emp_DOB, int phone, string street, int house_nr, string city, int department_id, double hourly_wage, double salary, string date,  string role)
        {
            string password = GeneratePassword();
            try
            {
                SendEmail(email, password); //If connected to cisco, sending email is unsuccessful.
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Cannot send e-mail with credentials. Check connection.");
            }

            password = Hashing.HashPassword(password);
            employeeDB.AddEmployee(first_name, last_name, email, password, emp_DOB, phone, street, house_nr, city, department_id, hourly_wage, salary, date, role);

        }

        public void RemoveEmployee(int id)
        {
            employeeDB.RemoveEmployee(id);
        }

        public void UpdateEmployee(int emp_id, string first_name, string last_name, string email, string emp_DOB, int phone, string street, int house_nr, string city, int department_id, int hourly_wage)
        {
            employeeDB.UpdateEmployee(emp_id, first_name, last_name, email, emp_DOB, phone, street, house_nr, city, department_id, hourly_wage);
        }

        public Employee GetSingleEmployee(int employeeId)
        {
            return employeeDB.GetSingleEmployee(employeeId);
        }

        public void RetireEmployee(string date, int employeeId)
        {
            employeeDB.RetireEmployee(date, employeeId);
        }

        public void AddRetirementHistory(int emp_id, string first_name, string last_name, string email, string emp_DOB, int phone, string street, int house_nr, string city, int department_id, string start_date, string retire_date, string role)
        {
            employeeDB.AddRetirementHistory(emp_id, first_name, last_name, email, emp_DOB, phone, street, house_nr, city, department_id, start_date, retire_date, role);
        }

        public void RehireEmployee(string date, int employeeId)
        {
            employeeDB.RehireEmployee(date, employeeId);
        }

        public List<Employee> GetAllActiveEmployees()
        {
            return employeeDB.GetAllActiveEmployees();
        }

        public List<Employee> GetUnassignedManagers(int departmentId)
        {
            return employeeDB.GetUnassignedManagers(departmentId);
        }

        public List<Employee> GetManagersOfDepartment(int departmentId)
        {
            return employeeDB.GetManagersOfDepartment(departmentId);
        }

        public void EditEmployee(int empId, string email, int phone, string street, int houseNr, string city)
        {
            employeeDB.EditEmployee(empId, email, phone, street, houseNr, city);
        }

        public int GetLeastShiftCountEmployeeId(string monthStartDate, string monthEndDate, string date, int department_id, string weekday, string timeFrame)
        {
            string preference;
            Unavailability unavailability;
            weekday = weekday.ToLower(); //lowercase for db column name
            List<int> activeEmployeeIds = employeeDB.GetActiveEmployeesInDepartment(department_id, date); //all active employees in the department
            List<int> leastAssignedShiftEmployeeList = employeeDB.GetLeastShiftCountEmployeeId(monthStartDate, monthEndDate, date, department_id); //Employees that have at least 1 shift assigned to them
            foreach (int id in activeEmployeeIds)
            {
                if(!leastAssignedShiftEmployeeList.Contains(id)) //Employee doesnt have any shifts assigned this month
                {

                    if (employeeDB.GetAssignedShiftCount(id, date) == 0)
                    {
                        Holiday holiday = employeeDB.GetHoliday(id);
                        if(holiday.GetEmployeeId() == 0 || !HasLeave(holiday, date))
                        {
                            preference = employeeDB.GetDayAvailability(weekday, id);
                            unavailability = UnavailabilityInterpreter(preference);

                            if (unavailability.Morning && timeFrame == "MORNING")
                            {
                                return id;
                            }
                            else if (unavailability.Afternoon && timeFrame == "AFTERNOON")
                            {
                                return id;
                            }
                            else if (unavailability.Evening && timeFrame == "EVENING")
                            {
                                return id;
                            }
                        }
                    }
                }
            }

            leastAssignedShiftEmployeeList = employeeDB.GetLeastShiftCountEmployeeId(monthStartDate, monthEndDate, date, department_id);


            for(int i = 0; i < leastAssignedShiftEmployeeList.Count; i++)
            { 
                int empId = leastAssignedShiftEmployeeList[i];
                if(employeeDB.GetAssignedShiftCount(empId, date) == 0)
                {
                    Holiday holiday = employeeDB.GetHoliday(empId);
                    if (holiday.GetEmployeeId() == 0 || !HasLeave(holiday, date))
                    {
                        preference = employeeDB.GetDayAvailability(weekday, empId);
                        unavailability = UnavailabilityInterpreter(preference);

                        if (unavailability.Morning && timeFrame == "MORNING")
                        {
                            return empId;
                        }
                        else if (unavailability.Afternoon && timeFrame == "AFTERNOON")
                        {
                            return empId;
                        }
                        else if (unavailability.Evening && timeFrame == "EVENING")
                        {
                            return empId;
                        }
                    }
                }
            }

            return 0;
        }

        public bool HasLeave(Holiday holiday, string curDate)
        {
            DateTime startDate = Convert.ToDateTime(holiday.GetStartDate());
            DateTime endDate = Convert.ToDateTime(holiday.GetEndDate());
            DateTime currentDate = Convert.ToDateTime(curDate);

            if(currentDate >= startDate && currentDate <= endDate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Unavailability UnavailabilityInterpreter(string preference)
        {

            if (preference == "ALL")
            {
                return new Unavailability(false, false, false);
            }
            else if (preference == "NONE")
            {
                return new Unavailability(true, true, true);
            }
            else if (preference == "MORNING")
            {
                return new Unavailability(false, true, true);
            }
            else if (preference == "AFTERNOON")
            {
                return new Unavailability(true, false, true);
            }
            else if (preference == "EVENING") 
            {
                return new Unavailability(true, true, false);
            }
            else
            {
                return new Unavailability(true, true, true);
            }

        }

    }
}
