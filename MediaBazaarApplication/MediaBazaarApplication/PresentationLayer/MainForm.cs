using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarApplication
{
    public partial class MainForm : Form
    {
        private Employee user;
        private StockLogic stockLogic;
        private DepartmentLogic departmentLogic;
        private ScheduleLogic scheduleLogic;
        private EmployeesLogic employeesLogic;
        
        public MainForm(Employee user)
        {
            InitializeComponent();
            this.user = user;
            stockLogic = new StockLogic();
            departmentLogic = new DepartmentLogic();
            scheduleLogic = new ScheduleLogic();
            employeesLogic = new EmployeesLogic();
            this.PopulateRestockGrid();
            PopulateDepartmentCb();
            PopulateHeaderValueEmployeeGrid();
            lblUserLastName.Text = Convert.ToString(user.GetName());
            lblLoggedInUserRole.Text = Convert.ToString(user.GetRole()) + " account";
        }

        private void btnStckMenu_Click(object sender, EventArgs e)
        {
            StockForm form = new StockForm(user);
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

        private void btnRestockToMin_Click(object sender, EventArgs e)//
        {
            try
            {
                if(RestockGridView.Rows.Count >= 1)
                {
                    foreach (DataGridViewRow row in RestockGridView.Rows)
                    {
                        int restockAmount = Convert.ToInt32(RestockGridView.Rows[row.Index].Cells[5].Value);
                        int currentAmount = Convert.ToInt32(RestockGridView.Rows[row.Index].Cells[4].Value);
                        int productID = Convert.ToInt32(RestockGridView.Rows[row.Index].Cells[0].Value);
                        stockLogic.RestockItem(restockAmount, currentAmount, productID);
                    }
                    this.PopulateRestockGrid();
                }
                else
                {
                    MessageBox.Show("Nothing to restock!", "All items above minimum quantity", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void PopulateRestockGrid()
        {
            try
            {
                int i = 0;
                RestockGridView.Rows.Clear();
                RestockGridView.Refresh();
                List<Item> restockingitem = stockLogic.GetItemsBelowMinQuantity();
                if (restockingitem.Count >= 1)
                {
                    if(restockingitem.Count != 1)
                    {
                        RestockGridView.Rows.Add((restockingitem.Count) - 1);
                    }

                    foreach (Item item in restockingitem)
                    {
                        if ((item.GetMinimumDifference()) > 0)
                        {
                            RestockGridView.Rows[i].Cells[0].Value = item.GetID();
                            RestockGridView.Rows[i].Cells[1].Value = item.GetName();
                            RestockGridView.Rows[i].Cells[2].Value = item.GetMinimumQuantity();
                            RestockGridView.Rows[i].Cells[3].Value = item.GetMaximumQuantity();
                            RestockGridView.Rows[i].Cells[4].Value = item.GetWarehouseAmount();
                            RestockGridView.Rows[i].Cells[5].Value = (item.GetMinimumDifference());
                            RestockGridView.Rows[i].Cells[6].Value = (item.GetMaximumDifference());

                            i++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void PopulateEmployeeGridView()
        {
            int maxAmount = 6;
            int department_id = Convert.ToInt32(departmentLogic.GetDepartmentId(Convert.ToString(cbDepartment.SelectedItem)));
            DateTime date = System.DateTime.Now;
            for (int i = 0; i < 14; i++)
            {
                int count = scheduleLogic.GetShiftCountByDayWithValidEmployees(date.AddDays(i).ToString("yyyy/MM/dd"), department_id); 
                dataGridEmpOverview.Rows[i].Cells[0].Value = $"{count} / {maxAmount}";
                if(count < 3)
                {
                    dataGridEmpOverview.Rows[i].Cells[0].Style.BackColor = Color.Red;
                }
                else if(count <= 5)
                {
                    dataGridEmpOverview.Rows[i].Cells[0].Style.BackColor = Color.Orange;
                }
                else
                {
                    dataGridEmpOverview.Rows[i].Cells[0].Style.BackColor = Color.Green;
                }
            }

        }

        private void btnAutoFill_Click(object sender, EventArgs e)
        {

            int department_id = Convert.ToInt32(departmentLogic.GetDepartmentId(Convert.ToString(cbDepartment.SelectedItem)));
            DateTime today = DateTime.Now;
            DateTime startMonth = new DateTime(today.Year, today.Month, 1);
            DateTime endOfMonth = new DateTime(today.Year, today.Month, DateTime.DaysInMonth(today.Year, today.Month));
            string endDate = endOfMonth.ToString("yyyy/MM/dd");
            string startDate = startMonth.ToString("yyyy/MM/dd");
            int maxAmount = (Convert.ToInt32(tbEmployeePerShift.Text)); //Employee count that has to be met while auto filling for that day

            for (int i = 0; i < Convert.ToInt32(tbAutoFillDaysAhead.Text); i++) //
            {
                string currentDate = today.AddDays(i).ToString("yyyy/MM/dd"); //day incrementer
                string currentWeekDay = today.AddDays(i).ToString("dddd");
                int count = scheduleLogic.GetShiftCountPerDay(currentDate, department_id); //Shift count of department for given date
                while (count < (maxAmount * 3))
                {
                    //Assign morning
                    if (scheduleLogic.GetShiftCountByTimeFrame("MORNING", currentDate, department_id) < maxAmount)//MORNING
                    {
                        int employeeId = employeesLogic.GetLeastShiftCountEmployeeId(startDate, endDate, currentDate, department_id, currentWeekDay, "MORNING");
                        scheduleLogic.AssignShift(employeeId, currentDate, "MORNING", department_id);
                    }
                    //Assign afternoon
                    else if (scheduleLogic.GetShiftCountByTimeFrame("AFTERNOON", currentDate, department_id) < maxAmount)//AFTERNOON
                    {
                        int employeeId = employeesLogic.GetLeastShiftCountEmployeeId(startDate, endDate, currentDate, department_id, currentWeekDay, "AFTERNOON");
                        scheduleLogic.AssignShift(employeeId, currentDate, "AFTERNOON", department_id);
                    }
                    //Assign evening
                    else if (scheduleLogic.GetShiftCountByTimeFrame("EVENING", currentDate, department_id) < maxAmount)//EVENING
                    {
                        int employeeId = employeesLogic.GetLeastShiftCountEmployeeId(startDate, endDate, currentDate, department_id, currentWeekDay, "EVENING");
                        scheduleLogic.AssignShift(employeeId, currentDate, "EVENING", department_id);
                    }
                    count = scheduleLogic.GetShiftCountPerDay(currentDate, department_id);
                }
            }
            

            PopulateEmployeeGridView();

        }

        public void PopulateHeaderValueEmployeeGrid()
        {
            DateTime date = System.DateTime.Now;
            dataGridEmpOverview.Rows.Add(13);
            dataGridEmpOverview.Rows[0].HeaderCell.Value = date.ToString("dddd");
            dataGridEmpOverview.Rows[1].HeaderCell.Value = date.AddDays(1).ToString("dddd");
            dataGridEmpOverview.Rows[2].HeaderCell.Value = date.AddDays(2).ToString("dddd");
            dataGridEmpOverview.Rows[3].HeaderCell.Value = date.AddDays(3).ToString("dddd");
            dataGridEmpOverview.Rows[4].HeaderCell.Value = date.AddDays(4).ToString("dddd");
            dataGridEmpOverview.Rows[5].HeaderCell.Value = date.AddDays(5).ToString("dddd");
            dataGridEmpOverview.Rows[6].HeaderCell.Value = date.AddDays(6).ToString("dddd");
            dataGridEmpOverview.Rows[7].HeaderCell.Value = date.AddDays(7).ToString("dddd");
            dataGridEmpOverview.Rows[8].HeaderCell.Value = date.AddDays(8).ToString("dddd");
            dataGridEmpOverview.Rows[9].HeaderCell.Value = date.AddDays(9).ToString("dddd");
            dataGridEmpOverview.Rows[10].HeaderCell.Value = date.AddDays(10).ToString("dddd");
            dataGridEmpOverview.Rows[11].HeaderCell.Value = date.AddDays(11).ToString("dddd");
            dataGridEmpOverview.Rows[12].HeaderCell.Value = date.AddDays(12).ToString("dddd");
            dataGridEmpOverview.Rows[13].HeaderCell.Value = date.AddDays(13).ToString("dddd");

            dataGridEmpOverview.DefaultCellStyle.SelectionBackColor = Color.White;
        }
        
        public void PopulateDepartmentCb()
        {
            cbDepartment.Items.Clear();
            List<string> departments = departmentLogic.GetDepNames();
            foreach (string department in departments)
            {
                cbDepartment.Items.Add(department);
            }
            cbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSelectDepartment_Click(object sender, EventArgs e)
        {
            if(cbDepartment.SelectedItem != null)
            {
                PopulateEmployeeGridView();
                dataGridEmpOverview.ClearSelection();
            }
            else
            {
                MessageBox.Show("Please pick a department to view a schedule.", "Department", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
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

        private void btn_RestockToMax_Click(object sender, EventArgs e)
        {
            try
            {
                if (RestockGridView.Rows.Count >= 1)
                {
                    foreach (DataGridViewRow row in RestockGridView.Rows)
                    {
                        int restockAmount = Convert.ToInt32(RestockGridView.Rows[row.Index].Cells[6].Value);
                        int currentAmount = Convert.ToInt32(RestockGridView.Rows[row.Index].Cells[4].Value);
                        int productID = Convert.ToInt32(RestockGridView.Rows[row.Index].Cells[0].Value);
                        stockLogic.RestockItem(restockAmount, currentAmount, productID);
                    }
                    this.PopulateRestockGrid();
                }
                else
                {
                    MessageBox.Show("Nothing to restock!", "All items above minimum quantity", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
