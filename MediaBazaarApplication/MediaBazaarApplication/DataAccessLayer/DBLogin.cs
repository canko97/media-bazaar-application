using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace MediaBazaarApplication
{
    public class DBLogin
    {
        DBConnectionHelper helperDB = new DBConnectionHelper();

        #region GetUser method / Returns Employee / Input email
        public Employee GetUser(string email)
        {
            Employee user = null;
            string sql = $"SELECT emp_id, first_name, last_name, email, password, emp_DOB, phone, street, house_nr, city, department_id, hourly_wage, salary, start_date, role FROM employees WHERE email = '{email}'";
            MySqlCommand command = new MySqlCommand(sql, helperDB.GetConnection());

            try
            {
                if (helperDB.GetConnection() != null) // changed this to != from the previous == 
                {
                    helperDB.OpenConnection();
                }
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int emp_id = Convert.ToInt32(reader["emp_id"]);
                    string first_name = Convert.ToString(reader["first_name"]);
                    string last_name = Convert.ToString(reader["last_name"]);
                    string e_mail = Convert.ToString(reader["email"]);
                    string password = Convert.ToString(reader["password"]);
                    string empDOB = Convert.ToString(reader["emp_DOB"]);
                    int phone = Convert.ToInt32(reader["phone"]);
                    string street = Convert.ToString(reader["street"]);
                    int houseNumber = Convert.ToInt32(reader["house_nr"]);
                    string city = Convert.ToString(reader["city"]);
                    int department_id = Convert.ToInt32(reader["department_id"]);
                    double hourly_wage = Convert.ToDouble(reader["hourly_wage"]);
                    double salary = Convert.ToDouble(reader["salary"]);
                    string role = Convert.ToString(reader["role"]);

                    user = new Employee(emp_id, first_name, last_name, e_mail, password, empDOB, phone, street, houseNumber, city, department_id, hourly_wage, salary, role);
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("GetUser is problematic");
            }
            finally
            {
                if (helperDB.GetConnection() != null) helperDB.CloseConnection();
            }

            return user;
        }
        #endregion

        #region GetPassword method / Returns string / Input email
        public string GetPassword(string email)
        {
            string pass = "";
            string sql = $"SELECT password FROM employees WHERE email = '{email}'";
            MySqlCommand command = new MySqlCommand(sql, helperDB.GetConnection());
            try
            {
                helperDB.OpenConnection();
                pass = Convert.ToString(command.ExecuteScalar());
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if (helperDB.GetConnection() != null) helperDB.CloseConnection();
            }
            return pass;
        }
        #endregion

        #region SetPassword method / Returns nothing / Input email, password
        public void SetPassword(string email, string newPassword)
        {
            helperDB.CloseConnection();
            try
            {
                helperDB.OpenConnection();
                string sql = $"UPDATE employees SET password = '{newPassword}' WHERE email = '{email}'";
                MySqlCommand command = new MySqlCommand(sql, helperDB.GetConnection());
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if (helperDB.GetConnection() != null) { helperDB.CloseConnection(); }
            }
        }
        #endregion
    }
}
