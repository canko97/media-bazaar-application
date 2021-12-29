using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApplication
{
    public class StockLogic
    {
        DBStock stockDB = new DBStock();

        public void RestockItem(int _restockAmount, int _currentAmount, int _productID )
        {
            int finalAmount = _restockAmount + _currentAmount;
            stockDB.RestockToMinAmount(_productID, finalAmount);
        }

        public List<Item> GetItemsBelowMinQuantity()
        {
            return stockDB.GetItemsBelowMinimumQuantity();
        }

        public void AddItem(string item_name, double price, string info, string category, int in_store_amount, int warehouse_amount, int min_quantity, int max_quantity)
        {
            stockDB.AddItem(item_name, price, info, category, in_store_amount, warehouse_amount, min_quantity, max_quantity);
        }

        public List<Item> GetItems()
        {
            return stockDB.GetItems();
        }

        public void UpdateAfterRestock(int itemId, int warehouseAmount)
        {
            stockDB.UpdateAfterRestock(itemId, warehouseAmount);
        }

        public void UpdateAfterStockToStore(int itemId, int inStoreAmount)
        {
            stockDB.UpdateAfterStockToStore(itemId, inStoreAmount);
        }

        public void DeleteStock(int itemId)
        {
            stockDB.DeleteStock(itemId);
        }

        public void UpdateItem(int item_id, string item_name, double item_price, string item_info, string item_category)
        {
            stockDB.UpdateItem(item_id, item_name, item_price, item_info, item_category);
        }

    }
}
