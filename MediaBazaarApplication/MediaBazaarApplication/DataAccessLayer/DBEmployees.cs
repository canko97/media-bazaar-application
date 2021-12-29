using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MediaBazaarApplication
{
    public class DBEmployees
    {
        DBConnectionHelper helperDB = new DBConnectionHelper();


        #region GetEmployeesByStatus method / Returns List<Employee> / Input cbStatusFilter

        public List<Employee> GetEmployeesByStatus(string cbFilter) //used for dataGridEmpList 
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            string sql;
            if (cbFilter == "Status: Employed")
            {
                sql = $"SELECT * FROM employees WHERE end_date > CURDATE() OR end_date IS NULL AND start_date <= CURDATE() ";
            }
            else
            {
                sql = $"SELECT * FROM employees WHERE end_date <= CURDATE()";
            }

            MySqlCommand command = new MySqlCommand(sql, connection);
            List<Employee> EmpInfoList = new List<Employee>();
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int emp_id = Convert.ToInt32(reader["emp_id"]);
                    string first_name = Convert.ToString(reader["first_name"]);
                    string last_name = Convert.ToString(reader["last_name"]);
                    string eMail = Convert.ToString(reader["email"]);
                    string password = Convert.ToString(reader["password"]);
                    string emp_DOB = Convert.ToString(Convert.ToDateTime(reader["emp_DOB"]).ToString("yyyy/MM/dd"));
                    int phone = Convert.ToInt32(reader["phone"]);
                    string street = Convert.ToString(reader["street"]);
                    int house_nr = Convert.ToInt32(reader["house_nr"]);
                    string city = Convert.ToString(reader["city"]);
                    int department_id = Convert.ToInt32(reader["department_id"]);
                    double salary = Convert.ToDouble(reader["salary"]);
                    double hourly_wage = Convert.ToDouble(reader["hourly_wage"]);
                    string start_date = Convert.ToString(Convert.ToDateTime(reader["start_date"]).ToString("yyyy/MM/dd"));
                    string end_date = null;
                    if(reader["end_date"] != DBNull.Value)
                    {
                        end_date = Convert.ToString(Convert.ToDateTime(reader["end_date"]).ToString("yyyy/MM/dd"));
                    }
                    string role = Convert.ToString(reader["role"]);
                    if (cbFilter == "Status: Employed")
                    {
                        EmpInfoList.Add(new Employee(emp_id, first_name, last_name, eMail, password, emp_DOB, phone, street, house_nr, city, department_id, hourly_wage, salary, start_date, role));
                    }
                    else
                    {
                        EmpInfoList.Add(new Employee(emp_id, first_name, last_name, eMail, password, emp_DOB, phone, street, house_nr, city, department_id, hourly_wage, salary, start_date, end_date, role));
                    }

                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return EmpInfoList;

        }

        #endregion

        #region GetRoles method / Returns List<String> / Input nothing

        public List<string> GetRoles()
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            string sql = "SELECT role_name FROM employee_roles";
            MySqlCommand command = new MySqlCommand(sql, connection);
            List<string> RolesList = new List<string>();
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string role = Convert.ToString(reader["role_name"]);
                    RolesList.Add(role);
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null) { connection.Close(); }
            }


            return RolesList;
        }
        #endregion

        #region GetAvailableEmplyees method / Returns List<Employee> / Input departmentId, date

        public List<Employee> GetAvailableEmployees(int departmentId, string date)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            string sql = $"select * from employees WHERE end_date > '{date}' OR end_date IS null AND department_id = {departmentId} AND emp_id NOT IN(SELECT emp_id from shifts where shift_date = '{date}')"; //SELECT emp_id, first_name, last_name FROM employees WHERE department_id = {departmentId} AND emp_id not in (SELECT emp_id FROM shifts WHERE shift_date = '{date}')
            MySqlCommand command = new MySqlCommand(sql, connection);
            List<Employee> availableEmpList = new List<Employee>();
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int emp_id = Convert.ToInt32(reader["emp_id"]);
                    string first_name = Convert.ToString(reader["first_name"]);
                    string last_name = Convert.ToString(reader["last_name"]);

                    availableEmpList.Add(new Employee(emp_id, first_name, last_name));
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return availableEmpList;
        }
        #endregion

        #region GetNameById method / Returns string / Input employeeId

        public string GetNameById(int employeeId)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            string sql = $"SELECT CONCAT(first_name, ' ', last_name) from employees where emp_id = {employeeId}";
            MySqlCommand command = new MySqlCommand(sql, connection);
            string employeeName = "empName";
            try
            {
                connection.Open();
                employeeName = Convert.ToString(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return employeeName;
        }

        #endregion

        #region AddEmployee method / Returns nothing / Input firstName, lastName, email, empDOB, phone, street, houseNr, city, departmentID, hourlyWage, salary, date, role

        public void AddEmployee(string first_name, string last_name, string email, string password, string emp_DOB, int phone, string street, int house_nr, string city, int department_id, double hourly_wage, double salary, string date, string role)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            try
            {
                connection.Open();
                string sql = $"INSERT INTO employees(first_name, last_name, email, password, emp_DOB, phone, street, house_nr, city, department_id, hourly_wage, salary, start_date, role) VALUES ('{first_name}', '{last_name}', '{email}', '{password}' , '{emp_DOB}', {phone}, '{street}', {house_nr}, '{city}', {department_id}, {hourly_wage}, {salary}, '{date}', '{role}')";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }
        #endregion

        #region RemoveEmployee method / Returns nothing / Input empId

        public void RemoveEmployee(int emp_id)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            string sql = $"DELETE FROM `employees` WHERE emp_id = {emp_id} ";
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        #endregion

        #region GetSingleEmployee method / Returns Employee / Input employeeId

        public Employee GetSingleEmployee(int employeeId)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            string sql = $"SELECT * FROM `employees` WHERE emp_id = {employeeId} ";
            MySqlCommand command = new MySqlCommand(sql, connection);
            Employee employee = null;
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int emp_id = Convert.ToInt32(reader["emp_id"]);
                    string first_name = Convert.ToString(reader["first_name"]);
                    string last_name = Convert.ToString(reader["last_name"]);
                    string eMail = Convert.ToString(reader["email"]);
                    string password = Convert.ToString(reader["password"]);
                    string emp_DOB = Convert.ToString(reader["emp_DOB"]);
                    int phone = Convert.ToInt32(reader["phone"]);
                    string street = Convert.ToString(reader["street"]);
                    int house_nr = Convert.ToInt32(reader["house_nr"]);
                    string city = Convert.ToString(reader["city"]);
                    int department_id = Convert.ToInt32(reader["department_id"]);
                    double salary = Convert.ToDouble(reader["salary"]);
                    double hourly_wage = Convert.ToDouble(reader["hourly_wage"]);
                    string start_date = Convert.ToString(reader["start_date"]);
                    string end_date = Convert.ToString(reader["end_date"]);
                    string role = Convert.ToString(reader["role"]);
                    employee = new Employee(emp_id, first_name, last_name, eMail, password, emp_DOB, phone, street, house_nr, city, department_id, hourly_wage, salary, start_date, end_date, role);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return employee;
        }

        #endregion

        #region UpdateEmployee method / Returns nothing / Input emp_id, first_name, last_name, email, emp_DOB, phone, street, house_nr, city, department_id, hourly_wage

        public void UpdateEmployee(int emp_id, string first_name, string last_name, string email, string emp_DOB, int phone, string street, int house_nr, string city, int department_id, int hourly_wage)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            string sql = $"UPDATE employees SET first_name = '{first_name}', last_name = '{last_name}', email = '{email}', emp_DOB = '{emp_DOB}', phone = {phone}, street = '{street}', house_nr = {house_nr}, city = '{city}', department_id = {department_id}, hourly_wage = {hourly_wage} WHERE emp_id = {emp_id}";
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        #endregion

        #region RetireEmployee method / Returns nothing / Input date, employeeId

        public void RetireEmployee(string date, int emp_id) 
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            try
            {
                connection.Open();
                string sql = $"UPDATE employees SET end_date = '{date}' WHERE emp_id = {emp_id}"; 
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }
        #endregion

        #region AddRetirementHistory method / Returns nothing / Input emp_id, first_name, last_name, email, emp_DOB, phone, street, house_nr, city, department_id, start_date, retire_date, role

        public void AddRetirementHistory(int emp_id, string first_name, string last_name, string email, string emp_DOB, int phone, string street, int house_nr, string city, int department_id, string start_date, string retire_date, string role)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            try
            {
                connection.Open();
                string sql = $"INSERT INTO retirement_history(emp_id, first_name, last_name, email, emp_DOB, phone, street, house_nr, city, department_id, start_date, retire_date, role) VALUES ({emp_id}, '{first_name}', '{last_name}', '{email}', '{emp_DOB}', {phone}, '{street}', {house_nr}, '{city}', {department_id}, '{start_date}', '{retire_date}', '{role}')";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }
        #endregion

        #region Rehire Employee method / Returns nothing / Input date, employeeId
        public void RehireEmployee(string date, int emp_id)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            try
            {
                connection.Open();
                string sql = $"UPDATE employees SET start_date = '{date}', end_date = NULL WHERE emp_id = {emp_id}";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null) { connection.Close(); }
            }
        }
        #endregion

        #region GetAllActiveEmployees method / Return List<Employee> / Input nothing

        public List<Employee> GetAllActiveEmployees()
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            string sql = $"SELECT * FROM employees WHERE end_date > CURDATE() OR end_date IS NULL AND start_date <= CURDATE()";

            MySqlCommand command = new MySqlCommand(sql, connection);
            List<Employee> EmpInfoList = new List<Employee>();
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int emp_id = Convert.ToInt32(reader["emp_id"]);
                    string first_name = Convert.ToString(reader["first_name"]);
                    string last_name = Convert.ToString(reader["last_name"]);
                    string eMail = Convert.ToString(reader["email"]);
                    string password = Convert.ToString(reader["password"]);
                    string emp_DOB = Convert.ToString(reader["emp_DOB"]);
                    int phone = Convert.ToInt32(reader["phone"]);
                    string street = Convert.ToString(reader["street"]);
                    int house_nr = Convert.ToInt32(reader["house_nr"]);
                    string city = Convert.ToString(reader["city"]);
                    int department_id = Convert.ToInt32(reader["department_id"]);
                    double salary = Convert.ToDouble(reader["salary"]);
                    double hourly_wage = Convert.ToDouble(reader["hourly_wage"]);
                    string start_date = Convert.ToString(reader["start_date"]);
                    string end_date = Convert.ToString(reader["end_date"]);
                    string role = Convert.ToString(reader["role"]);
                    EmpInfoList.Add(new Employee(emp_id, first_name, last_name, eMail, password, emp_DOB, phone, street, house_nr, city, department_id, hourly_wage, salary, start_date, role));

                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return EmpInfoList;

        }

        #endregion

        #region GetUnassignedManagers method / Return List<Employee> / Input departmentId
        public List<Employee> GetUnassignedManagers(int dep_id)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            string sql = $"SELECT * FROM employees WHERE role = 'Manager' AND emp_id not in (SELECT emp_id FROM department_manager WHERE department_id = {dep_id}); ";
            MySqlCommand command = new MySqlCommand(sql, connection);
            List<Employee> ManagersList = new List<Employee>();
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int emp_id = Convert.ToInt32(reader["emp_id"]);
                    string first_name = Convert.ToString(reader["first_name"]);
                    string last_name = Convert.ToString(reader["last_name"]);
                    string eMail = Convert.ToString(reader["email"]);
                    string password = Convert.ToString(reader["password"]);
                    string emp_DOB = Convert.ToString(reader["emp_DOB"]);
                    int phone = Convert.ToInt32(reader["phone"]);
                    string street = Convert.ToString(reader["street"]);
                    int house_nr = Convert.ToInt32(reader["house_nr"]);
                    string city = Convert.ToString(reader["city"]);
                    int department_id = Convert.ToInt32(reader["department_id"]);
                    double salary = Convert.ToDouble(reader["salary"]);
                    double hourly_wage = Convert.ToDouble(reader["hourly_wage"]);
                    string start_date = Convert.ToString(reader["start_date"]);
                    string role = Convert.ToString(reader["role"]);



                    ManagersList.Add(new Employee(emp_id, first_name, last_name, eMail, password, emp_DOB, phone, street, house_nr, city, department_id, hourly_wage, salary, start_date, role));
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return ManagersList;
        }
        #endregion

        #region GetManagersOfDepartment / Return List<Employee> / Input departmentId
        public List<Employee> GetManagersOfDepartment(int dep_id)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            string sql = $"select * from employees where emp_id IN (select emp_id FROM department_manager WHERE department_id = {dep_id})";
            List<Employee> managersOfDepartment = new List<Employee>();
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    int emp_id = Convert.ToInt32(reader["emp_id"]);
                    string first_name = Convert.ToString(reader["first_name"]);
                    string last_name = Convert.ToString(reader["last_name"]);
                    string eMail = Convert.ToString(reader["email"]);
                    string password = Convert.ToString(reader["password"]);
                    string emp_DOB = Convert.ToString(reader["emp_DOB"]);
                    int phone = Convert.ToInt32(reader["phone"]);
                    string street = Convert.ToString(reader["street"]);
                    int house_nr = Convert.ToInt32(reader["house_nr"]);
                    string city = Convert.ToString(reader["city"]);
                    int department_id = Convert.ToInt32(reader["department_id"]);
                    double salary = Convert.ToDouble(reader["salary"]);
                    double hourly_wage = Convert.ToDouble(reader["hourly_wage"]);
                    string start_date = Convert.ToString(reader["start_date"]);
                    string role = Convert.ToString(reader["role"]);
                    managersOfDepartment.Add(new Employee(emp_id, first_name, last_name, eMail, password, emp_DOB, phone, street, house_nr, city, department_id, hourly_wage, salary, start_date, role));
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return managersOfDepartment;
        }
        #endregion

        #region EditEmployee method / Return nothing / Input employeeId, email, phone, street, houseNumber, city

        public void EditEmployee(int empId, string email, int phone, string street, int houseNr, string city)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            try
            {
                connection.Open();
                string sql = $"UPDATE employees SET email = '{email}', phone = {phone}, street = '{street}', house_nr = {houseNr}, city = '{city}' WHERE emp_id = {empId}";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null) { connection.Close(); }
            }
        }

        #endregion

        #region GetLeastShiftCountEmployeeId method / returns int / department_id

        public List<int> GetLeastShiftCountEmployeeId(string monthStartDate, string monthEndDate, string date, int department_id)
        {
            helperDB.CloseConnection();
            string sql = $"SELECT e.emp_id FROM employees e INNER JOIN shifts s ON s.emp_id = e.emp_id WHERE s.shift_date BETWEEN '{monthStartDate}' AND '{monthEndDate}' AND s.shift_date != {date} AND e.department_id = {department_id} GROUP BY e.emp_id ORDER BY COUNT(e.emp_id)"; //SELECT emp_id , COUNT(emp_id) AS value_occurrence FROM employees WHERE department_id = {department_id} GROUP BY emp_id HAVING COUNT(value_occurrence) <= ALL( SELECT COUNT(emp_id) FROM shifts WHERE department_id = {department_id} GROUP BY emp_id) LIMIT 1
            MySqlCommand command = new MySqlCommand(sql, helperDB.GetConnection());
            List<int> employeeIds = new List<int>();
            try
            {
                helperDB.OpenConnection();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int emp_id = Convert.ToInt32(reader["emp_id"]);
                    employeeIds.Add(emp_id);
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                helperDB.CloseConnection();
            }

            return employeeIds;
        }
        #endregion

        #region GetAvailableEmplyees method / Returns List<Employee> / Input departmentId, date

        public List<int> GetActiveEmployeesInDepartment(int departmentId, string date)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            string sql = $"select emp_id from employees WHERE end_date > '{date}' OR end_date IS null AND department_id = {departmentId} AND emp_id NOT IN(SELECT emp_id from shifts where shift_date = '{date}')"; //SELECT emp_id, first_name, last_name FROM employees WHERE department_id = {departmentId} AND emp_id not in (SELECT emp_id FROM shifts WHERE shift_date = '{date}')
            MySqlCommand command = new MySqlCommand(sql, connection);
            List<int> availableEmpList = new List<int>();
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int emp_id = Convert.ToInt32(reader["emp_id"]);

                    availableEmpList.Add(emp_id);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return availableEmpList;
        }
        #endregion

        #region GetDayAvailability method / Returns string / Input timeFrame, weekday, employeeId

        public string GetDayAvailability(string weekday, int employeeId)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            string sql = $"SELECT {weekday} FROM `shift_preferences` WHERE emp_id = {employeeId}";
            MySqlCommand command = new MySqlCommand(sql, connection);
            string preference = "";
            try
            {
                connection.Open();
                preference = Convert.ToString(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return preference;
        }

        #endregion

        #region GetAssignedShiftCount method / Returns int / Input employeeId, date

        public int GetAssignedShiftCount(int employeeId, string date)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            string sql = $"SELECT COUNT(*) FROM shifts WHERE emp_id = {employeeId} AND shift_date = '{date}'";
            MySqlCommand command = new MySqlCommand(sql, connection);
            int shiftcount = 0;
            try
            {
                connection.Open();
                shiftcount = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return shiftcount;
        }

        #endregion

        #region GetApprovedHolidays method / Returns List<Holiday> / Input nothing

        public List<Holiday> GetApprovedHolidays()  
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            string sql = $"SELECT * FROM `employee_holiday` WHERE status = 'accepted'";
            MySqlCommand command = new MySqlCommand(sql, connection);
            List<Holiday> holidays = new List<Holiday>();


            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["emp_id"]);
                    string startDate = Convert.ToString(reader["start_date"]);
                    string endDate = Convert.ToString(reader["end_date"]);
                    string status = Convert.ToString(reader["status"]);

                    holidays.Add(new Holiday(id, startDate, endDate, status));
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return holidays;
        }

        #endregion

        #region GetHoliday method / returns Holiday / input employeeId

        public Holiday GetHoliday(int employeeId)
        {
            helperDB.CloseConnection();
            string sql = $"SELECT `emp_id`, `start_date`, `end_date`, `status` FROM `employee_holiday` WHERE emp_id = {employeeId}";
            MySqlCommand command = new MySqlCommand(sql, helperDB.GetConnection());
            Holiday holiday = new Holiday(0, "", "", "");
            try
            {
                helperDB.OpenConnection();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int empId = Convert.ToInt32(reader["emp_id"]);
                    string startDate = Convert.ToString(reader["start_date"]);
                    string endDate = Convert.ToString(reader["end_date"]);
                    string status = Convert.ToString(reader["status"]);

                    holiday = new Holiday(empId, startDate, endDate, status);
                }


            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                helperDB.CloseConnection();
            }

            return holiday;
        }
        #endregion

        /*            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();*/
    }
}
