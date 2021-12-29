using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MediaBazaarApplication
{
    public class DBStock
    {
        DBConnectionHelper helperDB = new DBConnectionHelper();

        #region RestockToMinAmount method / Returns nothing / Input item_id, warehouse_amount
        public void RestockToMinAmount (int item_id, int warehouse_amount)
        {
            helperDB.CloseConnection();
            try
            {
                helperDB.OpenConnection();
                string sql = $"UPDATE `items` SET `warehouse_amount`= @warehouse_amount WHERE `item_id` = @item_id";
                MySqlCommand command = new MySqlCommand(sql, helperDB.GetConnection());
                command.Parameters.AddWithValue("@warehouse_amount", warehouse_amount);
                command.Parameters.AddWithValue("@item_id", item_id);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                helperDB.CloseConnection();
            }
        }
        #endregion

        #region GetItemsBelowMinimumQuantity method / Returns List<Item> / Input nothing
        public List<Item> GetItemsBelowMinimumQuantity()
        {
            helperDB.CloseConnection();
            string sql = "SELECT * FROM items WHERE warehouse_amount<min_quantity";
            MySqlCommand command = new MySqlCommand(sql, helperDB.GetConnection());
            List<Item> itemsList = new List<Item>();
            try
            {
                helperDB.OpenConnection();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int itemId = Convert.ToInt32(reader["item_id"]);
                    string itemName = Convert.ToString(reader["item_name"]);
                    double price = Convert.ToDouble(reader["price"]);
                    string info = Convert.ToString(reader["info"]);
                    string category = Convert.ToString(reader["category"]);
                    int inStoreAmount = Convert.ToInt32(reader["in_store_amount"]);
                    int warehouse_amount = Convert.ToInt32(reader["warehouse_amount"]);
                    int minQuantity = Convert.ToInt32(reader["min_quantity"]);
                    int maxQuantity = Convert.ToInt32(reader["max_quantity"]);

                    itemsList.Add(new Item(itemId, itemName, price, info, category, inStoreAmount, warehouse_amount, minQuantity, maxQuantity));
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if (helperDB.GetConnection() != null) helperDB.CloseConnection();
            }

            return itemsList;
        }
        #endregion

        #region AddItem method / Returns nothing / Input item_name, price, info, category, in_store_amount, warehouse_amount, min_quantity

        public void AddItem(string item_name, double price, string info, string category, int in_store_amount, int warehouse_amount, int min_quantity, int max_quantity)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            try
            {
                connection.Open();

                string sql = $"Insert into items(item_name, price, info, category, in_store_amount, warehouse_amount, min_quantity, max_quantity)" +
                    $"values('{item_name}', {price}, '{info}', '{category}', {in_store_amount}, {warehouse_amount}, {min_quantity}, {max_quantity})";


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

        #region GetItems method / Return List<Item> / Input nothing

        public List<Item> GetItems()
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            string sql = "SELECT item_id, item_name, price, info, category, in_store_amount, warehouse_amount, min_quantity, max_quantity FROM items";
            MySqlCommand command = new MySqlCommand(sql, connection);
            List<Item> itemsList = new List<Item>();
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int itemId = Convert.ToInt32(reader["item_id"]);
                    string itemName = Convert.ToString(reader["item_name"]);
                    double price = Convert.ToDouble(reader["price"]);
                    string info = Convert.ToString(reader["info"]);
                    string category = Convert.ToString(reader["category"]);
                    int inStoreAmount = Convert.ToInt32(reader["in_store_amount"]);
                    int warehouse_amount = Convert.ToInt32(reader["warehouse_amount"]);
                    int minQuantity = Convert.ToInt32(reader["min_quantity"]);
                    int maxQuantity = Convert.ToInt32(reader["max_quantity"]);

                    itemsList.Add(new Item(itemId, itemName, price, info, category, inStoreAmount, warehouse_amount, minQuantity, maxQuantity));
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null) connection.Close();
            }

            return itemsList;
        }
        #endregion

        #region UpdateStockAfterRestock / Return nothing / Input itemId, warehouseAmount

        public void UpdateAfterRestock(int item_id, int warehouse_amount)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            try
            {
                connection.Open();
                string sql = $"UPDATE `items` SET `warehouse_amount`= @warehouse_amount WHERE `item_id` = @item_id";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@warehouse_amount", warehouse_amount);
                command.Parameters.AddWithValue("@item_id", item_id);
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

        #region UpdateAfterStockToStore / Return nothing / Input itemId, InStoreAmount

        public void UpdateAfterStockToStore(int item_id, int in_store_amount)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            try
            {
                connection.Open();
                string sql = $"UPDATE `items` SET `in_store_amount`= @in_store_amount WHERE `item_id` = @item_id";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@in_store_amount", in_store_amount);
                command.Parameters.AddWithValue("@item_id", item_id);
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

        #region DeleteStock / Returns nothing / Input itemId
        public void DeleteStock(int item_id)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            try
            {
                connection.Open();
                string sql = $"DELETE FROM `items` WHERE `item_id`= @item_id";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@item_id", item_id);
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

        #region UpdateItem method / Returns void / Input itemId, itemName, itemPrice, itemInfo, itemCategory

        public void UpdateItem(int item_id, string item_name, double item_price, string item_info, string item_category)
        {
            MySqlConnection connection = helperDB.GetConnection();
            connection.Close();

            try
            {
                connection.Open();
                string sql = $"UPDATE items SET item_name = @item_name, price = @item_price, info = @item_info, category = @item_category WHERE item_id = @item_id";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@item_id", item_id);
                command.Parameters.AddWithValue("@item_name", item_name);
                command.Parameters.AddWithValue("@item_price", item_price);
                command.Parameters.AddWithValue("@item_info", item_info);
                command.Parameters.AddWithValue("@item_category", item_category);
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

        /*            MySqlConnection connection = helperDB.GetConnection();
                    connection.Close();*/
    }


}
