using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace MediaBazaarApplication
{
    public class DBSchedule
    {
        DBConnectionHelper helperDB = new DBConnectionHelper();
        

        #region GetShiftCountByDay method / returns int / input date, department_id

        public int GetShiftCountByDay(string date, int department_id)
        {
            helperDB.CloseConnection();
            string sql = $"SELECT count(*) FROM shifts WHERE shift_date = '{date}' AND department_id = {department_id}";
            MySqlCommand command = new MySqlCommand(sql, helperDB.GetConnection());
            int count = 0;
            try
            {
                helperDB.OpenConnection();
                count = Convert.ToInt32(command.ExecuteScalar());

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                helperDB.CloseConnection();
            }

            return count;
        }
        #endregion

        #region GetShiftCountByDayWithValidEmployees method / returns int / input date, department_id

        public int GetShiftCountByDayWithValidEmployees(string date, int department_id)
        {
            helperDB.CloseConnection();
            string sql = $"SELECT count(*) FROM shifts WHERE shift_date = '{date}' AND department_id = {department_id} AND NOT emp_id = 0";
            MySqlCommand command = new MySqlCommand(sql, helperDB.GetConnection());
            int count = 0;
            try
            {
                helperDB.OpenConnection();
                count = Convert.ToInt32(command.ExecuteScalar());

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                helperDB.CloseConnection();
            }

            return count;
        }
        #endregion

        #region GetShiftsByDate method / returns List<Shift> / Input date, department_id

        public List<Shift> GetShifts(string date, int dep_id)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();
            string sql = $"SELECT shift_id, emp_id, shift_date, timeframe, department_id FROM shifts WHERE shift_date = '{date}' AND department_id = {dep_id}";
            MySqlCommand command = new MySqlCommand(sql, connection);
            List<Shift> shiftList = new List<Shift>();

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int shift_id = Convert.ToInt32(reader["shift_id"]);
                    int emp_id = Convert.ToInt32(reader["emp_id"]);
                    DateTime shift_date = Convert.ToDateTime(reader["shift_date"]);
                    string timeFrame = Convert.ToString(reader["timeframe"]);
                    int department_id = Convert.ToInt32(reader["department_id"]);

                    shiftList.Add(new Shift(shift_id, emp_id, shift_date, timeFrame, department_id));
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

            return shiftList;
        }
        #endregion

        #region DeleteShiftFromSchedule method / returns nothing / Input shiftId

        public void DeleteShiftFromSchedule(int shiftId)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();
            string sql = $"DELETE FROM `shifts` WHERE shift_id = {shiftId} ";
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

        #region AssignShift method / Returns nothing / Input employeeId, date, timeFrame, departmentId

        public void AssignShift(int emp_id, string date, string time_frame, int dep_id)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();
            try
            {
                connection.Open();
                string sql = $"INSERT INTO shifts(emp_id, shift_date, timeframe, department_id) VALUES ({emp_id}, '{date}', '{time_frame}', {dep_id})";
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

        #region UpdateShift method / Returns nothing / Input timeFrame, employeeId

        public void UpdateShift(string timeFrame, int emp_id, string date)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            string sql = $"UPDATE shifts SET timeframe = '{timeFrame}' WHERE emp_id = {emp_id} AND shift_date = '{date}'";
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

        #region GetShiftsOfEmployee method / Returns List<Shift> / Input employeeId
        public List<Shift> GetShiftOfEmployee(int emp_id)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();
            string sql = $"SELECT shift_date, timeframe FROM shifts WHERE emp_id = {emp_id} AND shift_date >= '{System.DateTime.Now.ToString("yyyy/MM/dd")}' ";
            MySqlCommand command = new MySqlCommand(sql, connection);
            List<Shift> shiftList = new List<Shift>();

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DateTime shift_date = Convert.ToDateTime(reader["shift_date"]);
                    string timeFrame = Convert.ToString(reader["timeframe"]);

                    shiftList.Add(new Shift(shift_date, timeFrame));
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

            return shiftList;
        }
        #endregion

        #region GetShiftPreferences method / Returns string[] / Input employeeId

        public string[] GetShiftPreferences(int employeeId)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            string sql = $"SELECT * FROM shift_preferences WHERE emp_id = {employeeId}";
            MySqlCommand command = new MySqlCommand(sql, connection);
            string[] days = new string[7];

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    days[0] = Convert.ToString(reader["monday"]);
                    days[1] = Convert.ToString(reader["tuesday"]);
                    days[2] = Convert.ToString(reader["wednesday"]);
                    days[3] = Convert.ToString(reader["thursday"]);
                    days[4] = Convert.ToString(reader["friday"]);
                    days[5] = Convert.ToString(reader["saturday"]);
                    days[6] = Convert.ToString(reader["sunday"]);
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

            return days;
        }

        #endregion

        #region AddShiftPreference method / Returns nothing / Input employeeId, days

        public void AddShiftPreference(int employeeId, string[] days)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();
            try
            {
                connection.Open();
                string sql = $"INSERT INTO `shift_preferences`(`emp_id`, `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`) VALUES ({employeeId}, '{days[0]}', '{days[1]}', '{days[2]}', '{days[3]}', '{days[4]}', '{days[5]}', '{days[6]}')";
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

        #region UpdateShiftPreference method / Returns nothing / Input employeeId, days

        public void UpdateShiftPreference(int employeeId, string[] days)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            string sql = $"UPDATE shift_preferences SET monday = '{days[0]}', tuesday = '{days[1]}', wednesday = '{days[2]}', thursday = '{days[3]}', friday = '{days[4]}', saturday = '{days[5]}', sunday = '{days[6]}' WHERE emp_id = {employeeId}";
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
      
        #region GetShiftCountByDay method / returns int / input date, department_id

        public int GetShiftCountByTimeFrame(string timeFrame ,string date, int department_id)
        {
            helperDB.CloseConnection();
            string sql = $"SELECT count(*) FROM shifts WHERE shift_date = '{date}' AND department_id = {department_id} AND timeframe = '{timeFrame}'";
            MySqlCommand command = new MySqlCommand(sql, helperDB.GetConnection());
            int count = 0;
            try
            {
                helperDB.OpenConnection();
                count = Convert.ToInt32(command.ExecuteScalar());

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                helperDB.CloseConnection();
            }

            return count;
        }
        #endregion

        #region AddHolidayRequest method / Returns nothing / Input employeeId, startDate, endDate, status

        public void AddHolidayRequest(int employeeId, string startDate, string endDate, string status)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();
            try
            {
                connection.Open();
                string sql = $"INSERT INTO `employee_holiday`(`emp_id`, `start_date`, `end_date`, `status`) VALUES ({employeeId}, '{startDate}', '{endDate}', '{status}')";
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

        #region GetAllHolidayRequests method / Returns List<Holiday> / Input nothing

        public List<Holiday> GetAllHolidayRequests()
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            string sql = $"SELECT * FROM `employee_holiday` WHERE status = 'pending'";
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

        #region RespondHolidayRequest method / Return nothing / Input Holiday

        public void RespondHolidayRequest(Holiday holiday)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            try
            {
                connection.Open();
                string sql = $"UPDATE `employee_holiday` SET status = '{holiday.Status}' WHERE emp_id = {holiday.GetEmployeeId()}";
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

        #region RequestHoliday method / Return nothing / Input Holiday

        public void RequestHoliday(Holiday holiday)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            try
            {
                connection.Open();
                string sql = $"UPDATE `employee_holiday` SET start_date = '{holiday.GetStartDate()}', end_date = '{holiday.GetEndDate()}', status = 'pending' WHERE emp_id = {holiday.GetEmployeeId()}";
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

        #region GetHoliday method / returns Holiday / input employeeId

        public Holiday GetHoliday(int employeeId)
        {

            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            string sql = $"SELECT * FROM `employee_holiday` WHERE emp_id = {employeeId}";
            MySqlCommand command = new MySqlCommand(sql, connection);
            Holiday holiday = new Holiday(0, "", "", "");
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
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
