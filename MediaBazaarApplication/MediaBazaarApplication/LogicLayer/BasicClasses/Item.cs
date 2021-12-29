using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApplication
{
    public class Item
    {

        private int itemId;
        private string itemName;
        private double price;
        private string info;
        private string category;
        private int inStoreAmount;
        private int warehouse_amount;
        private int minQuantity;
        private int maxQuantity;

        public Item(int itemId, 
                    string itemName, 
                    double price, 
                    string info, 
                    string category, 
                    int inStoreAmount, 
                    int warehouse_amount,
                    int minQuantity,
                    int maxQuantity)

        {
            this.itemId = itemId;
            this.itemName = itemName;
            this.price = price;
            this.info = info;
            this.category = category;
            this.inStoreAmount = inStoreAmount;
            this.warehouse_amount = warehouse_amount;
            this.minQuantity = minQuantity;
            this.maxQuantity = maxQuantity;
        }
        #region GetMethods
        public int GetID()
        {
            return this.itemId;
        }

        public string GetName()
        {
            return this.itemName;
        }

        public double GetPrice()
        {
            return this.price;
        }

        public string GetInfo()
        {
            return this.info;
        }

        public string GetCategory()
        {
            return this.category;
        }
        public int GetInStoreAmount()
        {
            return this.inStoreAmount;
        }
        public int GetWarehouseAmount()
        {
            return this.warehouse_amount;
        }
        public int GetMinimumQuantity()
        {
            return this.minQuantity;
        }
        public int GetMaximumQuantity()
        {
            return this.maxQuantity;
        }
        public int GetMinimumDifference()
        {
            return (this.minQuantity - this.warehouse_amount);
        }
        public int GetMaximumDifference()
        {
            return (this.maxQuantity - this.warehouse_amount);
        }

        #endregion
    }
}
