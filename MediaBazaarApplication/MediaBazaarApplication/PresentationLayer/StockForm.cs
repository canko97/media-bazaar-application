using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaBazaarApplication.CustomExceptions;
using MySql.Data.MySqlClient;

namespace MediaBazaarApplication
{
    public partial class StockForm : Form
    {
        Employee user;
        StockLogic stockLogic;
        
        public StockForm(Employee user)
        {
            InitializeComponent();
            this.user = user;
            stockLogic = new StockLogic();
            this.PopulateGrid();
            this.BelowMinimumCheck();
            tc_AddAndEdit.TabPages.Remove(tabEdit);
            lblUserLastName.Text = Convert.ToString(user.GetName());
            lblLoggedInUserRole.Text = Convert.ToString(user.GetRole()) + " account";
        }

        public void PopulateGrid() //oo
        {
            //POPULATES THE DATA GRID WITH ITEMS FROM THE "items" TABLE
            try
            {
                int i = 0;
                dgvItems.Rows.Clear();
                dgvItems.Refresh();
                List<Item> items = stockLogic.GetItems();
                dgvItems.Rows.Add((items.Count)-1);

                foreach (Item item in items)
                {
                    dgvItems.Rows[i].Cells[0].Value = item.GetID();
                    dgvItems.Rows[i].Cells[1].Value = item.GetName();
                    dgvItems.Rows[i].Cells[2].Value = item.GetPrice();
                    dgvItems.Rows[i].Cells[3].Value = item.GetInfo();
                    dgvItems.Rows[i].Cells[4].Value = item.GetCategory();
                    dgvItems.Rows[i].Cells[5].Value = item.GetInStoreAmount();
                    dgvItems.Rows[i].Cells[6].Value = item.GetWarehouseAmount();
                    dgvItems.Rows[i].Cells[7].Value = item.GetMinimumQuantity();
                    dgvItems.Rows[i].Cells[8].Value = item.GetMaximumQuantity();
                    i++;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void FinalStockAmount(int StockCount)
        {
            int rowIndex = dgvItems.CurrentRow.Index;
            dgvItems.Rows[rowIndex].Cells[6].Value = StockCount;
        }
        public void FinalStoreStockAmount(int StockCount)
        {
            int rowIndex = dgvItems.CurrentRow.Index;
            dgvItems.Rows[rowIndex].Cells[5].Value = StockCount;
        }
        public int FindStockQuantity()
        {
            int rowIndex = dgvItems.CurrentRow.Index;
            return Convert.ToInt32(dgvItems.Rows[rowIndex].Cells[6].Value);
        }
        public int FindStoreAmount()
        {
            int rowIndex = dgvItems.CurrentRow.Index;
            return Convert.ToInt32(dgvItems.Rows[rowIndex].Cells[5].Value);
        }
        public int FindProductID()
        {
            int rowIndex = dgvItems.CurrentRow.Index;
            return Convert.ToInt32(dgvItems.Rows[rowIndex].Cells[0].Value);
        }
        public void BelowMinimumCheck() //oo
        {
            for (int i = 0; i < dgvItems.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvItems.Rows[i].Cells[6].Value) < (Convert.ToInt32(dgvItems.Rows[i].Cells[7].Value)))
                {
                    dgvItems.Rows[i].Cells[6].Style.BackColor = Color.Red;
                }
                else
                {
                    dgvItems.Rows[i].Cells[6].Style.BackColor = Color.White;
                }
            }
        }


        private void dgvItems_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.BelowMinimumCheck();
        }

        private void btnHomeMenu_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm(user);
            try
            {
                form.Show();
                this.Close();
            }
            catch (InvalidOperationException)
            {
                form.Show();
                this.Close();
            }
        }

        private void btnEmpMenu_Click(object sender, EventArgs e)
        {
            EmployeesForm form = new EmployeesForm(user);
            try
            {
                form.Show();
                this.Close();
            }
            catch (InvalidOperationException)
            {
                form.Show();
                this.Close();
            }
        }

        private void btnDepMenu_Click(object sender, EventArgs e)
        {
            DepartmentsForm form = new DepartmentsForm(user);
            try
            {
                form.Show();
                this.Close();
            }
            catch (InvalidOperationException)
            {
                form.Show();
                this.Close();
            }
        }

        private void StockForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogInForm form = new LogInForm();
            try
            {
                form.Show();
                this.Close();
            }
            catch (InvalidOperationException)
            {
                form.Show();
                this.Close();
            }
        }

        public void PopulateTextBoxes() //oo
        {
            tc_AddAndEdit.TabPages.Add(tabEdit);
            tc_AddAndEdit.TabPages.Remove(tabPage1);
            tc_AddAndEdit.SelectedTab = tabEdit;
            List<Item> StockList = stockLogic.GetItems();

            foreach (Item item in StockList)
            {
                if (Convert.ToString(item.GetID()) == Convert.ToString(dgvItems.CurrentRow.Cells[0].Value))
                {
                    lbl_Item_Id.Text = Convert.ToString(item.GetID());
                    tb_editItemName.Text = item.GetName();
                    tb_editPrice.Text = Convert.ToString(item.GetPrice());
                    tb_editInfo.Text = item.GetInfo();
                    cb_editCategory.SelectedItem = item.GetCategory();    
                }
            }

        }

        private void btnAddItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                Regex OnlyWords = new Regex(@"^[a-zA-Z]+$");
                //Add a new item with the values from the text boxes into the Items table
                string itemName = tbItemName.Text;
                if (OnlyWords.IsMatch(Convert.ToString(tbPrice.Text)))
                {
                    throw new NumberInsteadOfLettersException(itemName, "price");
                }
                double price = Convert.ToDouble(tbPrice.Text);
                if (price < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                string info = Convert.ToString(tbInfo.Text);
                string category = Convert.ToString(cbCategory.SelectedItem);
                if (OnlyWords.IsMatch(Convert.ToString(tbInStoreAmount.Text)))
                {
                    throw new NumberInsteadOfLettersException(itemName, "in store amount");
                }
                int inStoreAmount = Convert.ToInt32(tbInStoreAmount.Text);
                if (inStoreAmount < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (OnlyWords.IsMatch(Convert.ToString(tbQuantity.Text)))
                {
                    throw new NumberInsteadOfLettersException(itemName, "warehouse amount");
                }
                int warehouse_amount = Convert.ToInt32(tbQuantity.Text);
                if (warehouse_amount < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (OnlyWords.IsMatch(Convert.ToString(tbMinQuantity.Text)))
                {
                    throw new NumberInsteadOfLettersException(itemName, "minimum quantity");
                }
                int minQuantity = Convert.ToInt32(tbMinQuantity.Text);
                if (minQuantity < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (warehouse_amount < minQuantity)
                {
                    throw new LowerThanMinQuantityException(itemName);
                }
                int maxQuantity = Convert.ToInt32(tbMaxQuantity.Text);
                if (maxQuantity <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (maxQuantity < warehouse_amount)
                { throw new LowerThanTheQuantity(itemName); }
                if (maxQuantity < minQuantity)
                {
                    throw new MaxLowerThanMinQuantityException(itemName);
                }


                stockLogic.AddItem(itemName, price, info, category, inStoreAmount, warehouse_amount, minQuantity, maxQuantity);
                this.PopulateGrid();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("All numbers must be positive!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Not everything is filled in!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRestock_Click_1(object sender, EventArgs e)
        {
            try
            {
                int restockAmount = Convert.ToInt32(tb_AmountRestocked.Text);
                if (restockAmount > 0)
                {
                    int currentAmount = FindStockQuantity();
                    int finalAmount = restockAmount + currentAmount;
                    FinalStockAmount(finalAmount);
                    int productID = FindProductID();
                    stockLogic.UpdateAfterRestock(productID, finalAmount);
                    BelowMinimumCheck();
                    dgvItems.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Please input a positive number");
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Please insert numbers");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_AddToStore_Click_1(object sender, EventArgs e)
        {
            try
            {
                int restockAmount = Convert.ToInt32(tb_AmountToStore.Text);
                if (restockAmount >= 0)
                {
                    int currentAmount = FindStoreAmount();
                    int QuantitycurrentAmount = FindStockQuantity();
                    int finalAmount = currentAmount + restockAmount;
                    int FinalWareHouseAmount = QuantitycurrentAmount - restockAmount;
                    FinalStoreStockAmount(finalAmount);
                    FinalStockAmount(FinalWareHouseAmount);
                    int productID = FindProductID();
                    stockLogic.UpdateAfterRestock(productID, FinalWareHouseAmount);
                    stockLogic.UpdateAfterStockToStore(productID, finalAmount);
                    BelowMinimumCheck();
                    dgvItems.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Please input a positive number");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please insert a number");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                int rowindex = dgvItems.CurrentRow.Index;
                int item_id = Convert.ToInt32(dgvItems.Rows[rowindex].Cells[0].Value);
                string item_name = Convert.ToString(dgvItems.Rows[rowindex].Cells[1].Value);
                var deletionItem = MessageBox.Show($"Are you sure you want to delete {item_name}?", "Delete item", MessageBoxButtons.YesNo);
                if (deletionItem == DialogResult.Yes)
                {
                    stockLogic.DeleteStock(item_id);
                    MessageBox.Show($"You successfully deleted {item_name}");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.PopulateGrid();
            }
        }

        private void btn_EditItem_Click_1(object sender, EventArgs e)
        {
            int SelectedRow = dgvItems.CurrentRow.Index;
            if (SelectedRow >= 0)
            {
                this.PopulateTextBoxes();
            }
        }

        private void btn_EditStockBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                int edititem_id = Convert.ToInt32(lbl_Item_Id.Text);
                Regex OnlyWords = new Regex(@"^[a-zA-Z]+$");
                string editname = tb_editItemName.Text;
                if (OnlyWords.IsMatch(Convert.ToString(tb_editPrice.Text)))
                {
                    throw new NumberInsteadOfLettersException(editname, "price");
                }
                double editprice = Convert.ToDouble(tb_editPrice.Text);
                if (editprice < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                string editinfo = Convert.ToString(tb_editInfo.Text);
                string editcategory = Convert.ToString(cb_editCategory.SelectedItem);

                stockLogic.UpdateItem(edititem_id, editname, editprice, editinfo, editcategory);
                this.PopulateGrid();
                tc_AddAndEdit.TabPages.Remove(tabEdit);
                tc_AddAndEdit.TabPages.Add(tabPage1);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("All numbers must be positive!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_return_Click_1(object sender, EventArgs e)
        {
            tc_AddAndEdit.TabPages.Remove(tabEdit);
            tc_AddAndEdit.TabPages.Add(tabPage1);
        }
    }
    
}

