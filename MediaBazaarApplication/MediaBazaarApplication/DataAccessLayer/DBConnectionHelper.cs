using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MediaBazaarApplication
{
    public class DBConnectionHelper
    {
        #region Connection With Database
        ///<summary>
        ///MySQLConnection
        ///<summary>
        private string connectionString;
        private MySqlConnection connection;

        public DBConnectionHelper()
        {
            this.connectionString = @"Server=localhost;" + //localhost   //studmysql01.fhict.local
                                    "database=dbi401477;" +
                                    "user id=root;" + //root   //dbi401477
                                    "password=;" + //      //dbi401477
                                    "connect timeout=30;";
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            return this.connection;
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }
        #endregion
    }
}
