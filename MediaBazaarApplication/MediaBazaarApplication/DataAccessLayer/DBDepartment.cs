using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient; 

namespace MediaBazaarApplication
{
    public class DBDepartment
    {
        DBConnectionHelper helperDB = new DBConnectionHelper();

        #region GetDepartmentId method / Returns int / Input departmentName 
        public int GetDepartmentId(string departmentName)
        {
            helperDB.CloseConnection();

            int departmentId = 0;
            string sql = $"SELECT department_id FROM departments WHERE department_name = '{departmentName}'";
            MySqlCommand command = new MySqlCommand(sql, helperDB.GetConnection());

            try
            {
                helperDB.GetConnection().Open();
                departmentId = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                helperDB.CloseConnection();
            }

            return departmentId;
        }
        #endregion

        #region GetDepartmentNames / Returns List<string> / No input
        public List<string> GetDepartmentNames()
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            string sql = "SELECT department_name FROM departments";
            MySqlCommand command = new MySqlCommand(sql, connection);
            List<string> departmentList = new List<string>();
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string departmentName = Convert.ToString(reader["department_name"]);
                    departmentList.Add(departmentName);
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

            return departmentList;
        }
        #endregion

        #region GetDepartmentName / Returns string / Input departmentId

        public string GetDepartmentName(int departmentId)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            string department_name = "unknown";
            string sql = $"SELECT department_name FROM departments WHERE department_id = '{departmentId}'";
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                department_name = Convert.ToString(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return department_name;
        }

        #endregion

        #region GetAllDepartments method / Returns MySqlDataAdapter / Input nothing
        
        public MySqlDataAdapter GetAllDepartments()
        {

            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();
            MySqlDataAdapter sqlDA = null;
            string sql = "SELECT * FROM departments";
            
            try
            {
                connection.Open();

                sqlDA = new MySqlDataAdapter(sql, connection);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return sqlDA;
        }

        #endregion

        #region AddDepartment method / Returns nothing / Input departmentName
        public void AddDepartment(string departmentName)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            try
            {
                connection.Open();
                string sql = $"Insert into departments(department_name)" +
                    $"values('{departmentName}')";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.ExecuteNonQuery();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("That department already exists!");
            }
            finally
            {
                if (connection != null) { connection.Close(); }
            }
        }
        #endregion

        #region EditDepartment method / Returns nothing / Input departmentId, departmentName
        public void EditDepartment(int departmentId, string departmentName)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            try
            {
                connection.Open();
                string sql = $"UPDATE departments SET department_name = '{departmentName}' WHERE department_id = {departmentId}";
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

        #region DeleteDepartment method / Returns nothing / Input departmentId
        public void DeleteDepartment(int departmentId)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            string sql = $"DELETE FROM `departments` WHERE department_id = {departmentId};";
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
                if (connection != null) connection.Close();
            }
        }
        #endregion

        #region AssignManagerToDepartment method / Returns nothing / Input managerId, departmentId
        public void AssignManagerToDepartment(int manager_id, int department_id)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            try
            {
                connection.Open();

                string sql = $"Insert into department_manager(emp_id, department_id)" +
                    $"values('{manager_id}', {department_id})";

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

        #region ResignManager method / Returns nothing / Input employeeId, departmentId

        public void ResignManager(int emp_id, int department_id)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            string sql = $"DELETE FROM department_manager WHERE emp_id = {emp_id} AND department_id = { department_id}";
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
    }
}
