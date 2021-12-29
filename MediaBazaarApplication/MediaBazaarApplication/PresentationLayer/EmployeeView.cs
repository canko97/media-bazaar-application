using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace MediaBazaarApplication
{
    public partial class EmployeeView : Form
    {
        Employee user;
        EmployeesLogic employeesLogic;
        StockLogic stockLogic;
        DepartmentLogic departmentLogic;
        ScheduleLogic scheduleLogic;

        public EmployeeView(Employee user)
        {
            InitializeComponent();
            this.user = user;
            employeesLogic = new EmployeesLogic();
            stockLogic = new StockLogic();
            departmentLogic = new DepartmentLogic();
            scheduleLogic = new ScheduleLogic();
            PopulateUser();
            PopulateGrid();
            PopulatePersonalSchedule();
            btnRefreshSchedule.Hide();
            gridEmpPersonalSchedule.Hide();
            FillUnavailabilityCb(user.GetID());
            SetHolidayRequestStatus();
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
                dgvItems.Rows.Add(items.Count);
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
                    i++;

                }
                BelowMinimumCheck();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void FillUnavailabilityCb(int employeeId)
        {
            string[] days;
            days = scheduleLogic.GetShiftPreferences(employeeId);
            if (days[0] != null)
            {
                cbMonday.SelectedIndex = cbMonday.FindStringExact(days[0]);
                cbTuesday.SelectedIndex = cbTuesday.FindStringExact(days[1]);
                cbWednesday.SelectedIndex = cbWednesday.FindStringExact(days[2]);
                cbThursday.SelectedIndex = cbThursday.FindStringExact(days[3]);
                cbFriday.SelectedIndex = cbFriday.FindStringExact(days[4]);
                cbSaturday.SelectedIndex = cbSaturday.FindStringExact(days[5]);
                cbSunday.SelectedIndex = cbSunday.FindStringExact(days[6]);
            }
            else
            {
                cbMonday.SelectedIndex = cbMonday.FindStringExact("NONE");
                cbTuesday.SelectedIndex = cbTuesday.FindStringExact("NONE");
                cbWednesday.SelectedIndex = cbWednesday.FindStringExact("NONE");
                cbThursday.SelectedIndex = cbThursday.FindStringExact("NONE");
                cbFriday.SelectedIndex = cbFriday.FindStringExact("NONE");
                cbSaturday.SelectedIndex = cbSaturday.FindStringExact("NONE");
                cbSunday.SelectedIndex = cbSunday.FindStringExact("NONE");
            }
        }
        
        public void PopulateUser() //oo
        {
            lblFirstName.Text = user.GetFirstName();
            lblLastName.Text = user.GetLastName();
            lblId.Text = Convert.ToString(user.GetID());
            tbEmail.Text = user.GetEmail();
            lblDOB.Text = Convert.ToDateTime(user.EmpDOB()).ToString("yyyy/MM/dd");
            tbPhone.Text = Convert.ToString(user.GetPhone());
            tbStreet.Text = user.GetStreet();
            tbHouseNr.Text = Convert.ToString(user.GetHouseNr());
            tbCity.Text = user.GetCity();
        }
        private void btnSave_Click(object sender, EventArgs e) //oo
        {
            int Id = Convert.ToInt32(lblId.Text);
            string email = tbEmail.Text;
            int phone = Convert.ToInt32(tbPhone.Text);
            string street = tbStreet.Text;
            int houseNr = Convert.ToInt32(tbHouseNr.Text);
            string city = tbCity.Text;
            employeesLogic.EditEmployee(Id, email, phone, street, houseNr, city);
            SetShiftPreference();
            MessageBox.Show("Saved!");
        }

        public void SetShiftPreference()
        {
            string[] days = new string[7];
            days[0] = cbMonday.SelectedItem.ToString();
            days[1] = cbTuesday.SelectedItem.ToString();
            days[2] = cbWednesday.SelectedItem.ToString();
            days[3] = cbThursday.SelectedItem.ToString();
            days[4] = cbFriday.SelectedItem.ToString();
            days[5] = cbSaturday.SelectedItem.ToString();
            days[6] = cbSunday.SelectedItem.ToString();
            scheduleLogic.SetShiftPreferences(user.GetID(), days);
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
        public int FindProductID()
        {
            int rowIndex = dgvItems.CurrentRow.Index;
            return Convert.ToInt32(dgvItems.Rows[rowIndex].Cells[0].Value);
        }

        private void EmployeeView_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        private void btnRestock_Click_1(object sender, EventArgs e) //oo
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
                    this.BelowMinimumCheck();
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

        public void BelowMinimumCheck()
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
        public int FindStoreAmount()
        {
            int rowIndex = dgvItems.CurrentRow.Index;
            return Convert.ToInt32(dgvItems.Rows[rowIndex].Cells[5].Value);
        }

        private void btn_Destock_Click_1(object sender, EventArgs e) //oo
        {
            try
            {
                int restockAmount = Convert.ToInt32(tb_StockToStore.Text);
                if (restockAmount > 0)
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

        private void dgvItems_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.BelowMinimumCheck();
        }

        public void PopulatePersonalSchedule() //oo
        {
            int emp_id = Convert.ToInt32(lblId.Text);
            List<Shift> shifts = scheduleLogic.GetShiftsOfEmployee(emp_id);
            int i = 0;
            DateTime lastDate = Convert.ToDateTime(System.DateTime.Now.ToString("yyyy/MM/dd"));
            int rowAmount = shifts.Count;
            if (rowAmount > 1) //avoiding extra rows and not enough rows    
            {
                rowAmount--;
                gridEmpPersonalSchedule.Rows.Add(rowAmount);
            }
            foreach (Shift shift in shifts)
            {
                string date = shift.ShiftDate.ToString("yyyy/MM/dd");
                gridEmpPersonalSchedule.Rows[i].HeaderCell.Value = date;
                scheduleColoring(shift.TimeFrame, i);
                i++;
            }

        }

        public void scheduleColoring(string timeFrame, int i)
        {
            if (timeFrame == "MORNING")
            {
                gridEmpPersonalSchedule.Rows[i].Cells[0].Style.BackColor = Color.Green;
            }
            if (timeFrame == "AFTERNOON")
            {
                gridEmpPersonalSchedule.Rows[i].Cells[1].Style.BackColor = Color.Green;
            }
            if (timeFrame == "EVENING")
            {
                gridEmpPersonalSchedule.Rows[i].Cells[2].Style.BackColor = Color.Green;
            }
            if (timeFrame == "MORNING-AFTERNOON")
            {
                gridEmpPersonalSchedule.Rows[i].Cells[0].Style.BackColor = Color.Green;
                gridEmpPersonalSchedule.Rows[i].Cells[1].Style.BackColor = Color.Green;
            }
            if (timeFrame == "MORNING-EVENING")
            {
                gridEmpPersonalSchedule.Rows[i].Cells[0].Style.BackColor = Color.Green;
                gridEmpPersonalSchedule.Rows[i].Cells[1].Style.BackColor = Color.Green;
                gridEmpPersonalSchedule.Rows[i].Cells[2].Style.BackColor = Color.Green;
            }
            if (timeFrame == "AFTERNOON-EVENING")
            {
                gridEmpPersonalSchedule.Rows[i].Cells[1].Style.BackColor = Color.Green;
                gridEmpPersonalSchedule.Rows[i].Cells[2].Style.BackColor = Color.Green;
            }


        }

        private void btnViewPersonalSchedule_Click(object sender, EventArgs e)
        {
            gridEmpPersonalSchedule.Show();
            gridEmpPersonalSchedule.ClearSelection();
            btnViewPersonalSchedule.Hide();
            btnRefreshSchedule.Show();
        }

        private void btnRefreshSchedule_Click(object sender, EventArgs e)
        {
            PopulatePersonalSchedule();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogInForm form = new LogInForm();
            form.Show();
            this.Close();
        }

        private void btnRequestHoliday_Click(object sender, EventArgs e)
        {
            string startDate = dtpHolidayStart.Value.ToString("yyyy/MM/dd");
            string endDate = dtpHolidayEnd.Value.ToString("yyyy/MM/dd");
            if(scheduleLogic.GetHoliday(user.GetID()).GetEmployeeId() == 0)
            {
                scheduleLogic.AddHolidayRequest(user.GetID(), startDate, endDate);
            }
            else //If employee already has a holiday row in db
            {
                scheduleLogic.RequestHoliday(new Holiday(user.GetID(), startDate, endDate, "pending"));
            }

            MessageBox.Show("Request sent!");
            SetHolidayRequestStatus();
        }

        public void SetHolidayRequestStatus()
        {
            Holiday holiday = scheduleLogic.GetHoliday(user.GetID());
            if(holiday.Status == "pending")
            {
                lblHolidayApproval.ForeColor = Color.White;
                lblHolidayApproval.Text = "Request pending...";
            }
            else if(holiday.Status == "accepted")
            {
                lblHolidayApproval.ForeColor = Color.Lime;
                lblHolidayApproval.Text = "Last request approved!";
            }
            else if(holiday.Status == "denied")
            {
                lblHolidayApproval.ForeColor = Color.Red;
                lblHolidayApproval.Text = "Last request denied!";    
            }
        }
    }
}
