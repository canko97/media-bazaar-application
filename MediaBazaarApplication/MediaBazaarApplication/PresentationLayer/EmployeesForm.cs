using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Web;
using System.Net.Mail;

namespace MediaBazaarApplication
{
    public partial class EmployeesForm : Form
    {
        Employee user;
        EmployeesLogic employeesLogic;
        ScheduleLogic scheduleLogic;
        DepartmentLogic departmentLogic;
        PDFGenerator pDFGenerator;
        

        public EmployeesForm(Employee user)
        {
            InitializeComponent();
            this.user = user;
            pDFGenerator = new PDFGenerator();
            employeesLogic = new EmployeesLogic();
            scheduleLogic = new ScheduleLogic();
            departmentLogic = new DepartmentLogic();

            populateComboBox();
            PopulateEmployeeListGrid();
            PopulateRoleCb();
            tcEmpList.TabPages.Remove(tabEditEmployee);
            lblUserLastName.Text = Convert.ToString(user.GetName());
            lblLoggedInUserRole.Text = Convert.ToString(user.GetRole()) + " account";
            btnFinishScheduleEdit.Hide();
            btnReHire.Hide();
            cbEmployeeStatusFIlter.DropDownStyle = ComboBoxStyle.DropDownList;
            PopulateHolidayRequests();
        }

        private void btnScheduleLookUp_Click(object sender, EventArgs e) //oo
        {
            if (cbScheduleDep.SelectedItem == null)
            {
                MessageBox.Show("Please pick a department you would like to view the schedule of.", "Department", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
            else
            {
                PopulateGridSchedule();
                PopulateListBox();
            }

        }

        public void PopulateHolidayRequests()
        {
            lbEmployeeHolidayRequests.Items.Clear();
            foreach(Holiday holiday in scheduleLogic.GetAllHolidayRequests())
            {
                lbEmployeeHolidayRequests.Items.Add($"Employee ID: {holiday.GetEmployeeId()}, Start Date: {Convert.ToDateTime(holiday.GetStartDate()).ToString("yyyy/MM/dd")}, End Date: {Convert.ToDateTime(holiday.GetEndDate()).ToString("yyyy/MM/dd")}");
            }
        }

        private void btnScheduleEmpRemove_Click(object sender, EventArgs e) //oo
        {
            if (dataGridSchedule.CurrentRow != null)
            {
                string departmentName = cbScheduleDep.SelectedItem.ToString();
                int departmentId = departmentLogic.GetDepartmentId(departmentName);
                string date = Convert.ToString(datePickSchedule.Value.ToString("yyyy/MM/dd"));
                string emp = Convert.ToString(dataGridSchedule.CurrentRow.HeaderCell.Value);
                List<Shift> shifts = scheduleLogic.GetShifts(date, departmentId);
                foreach (Shift shift in shifts)
                {
                    if (emp != null)
                    {
                        if (employeesLogic.GetNameById(shift.EmployeeId) == emp)
                        {
                            scheduleLogic.DeleteShiftFromSchedule(shift.ShiftId);
                            PopulateListBox();
                        }
                    }

                }
                PopulateGridSchedule();
            }
            else
            {
                MessageBox.Show("Please select the shift you want to remove!");
            }
                
        }

        public void populateComboBox() //oo
        {
            cbScheduleDep.Items.Clear();
            foreach (string item in departmentLogic.GetDepNames())
            {
                cbScheduleDep.Items.Add(item);
                cbDepartment.Items.Add(item);
                cbDepartmentEdit.Items.Add(item);
            }

            cbScheduleDep.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDepartmentEdit.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btnScheduleAssignEmp_Click(object sender, EventArgs e) //oo
        {
            if (lbAvailableEmployees.SelectedItem != null)
            {
                string departmentName = cbScheduleDep.SelectedItem.ToString();
                int departmentId = departmentLogic.GetDepartmentId(departmentName);
                string date = Convert.ToString(datePickSchedule.Value.ToString("yyyy/MM/dd"));
                string available_emp = Convert.ToString(lbAvailableEmployees.SelectedItem);
                Regex reg = new Regex(@"\d*\d");
                string emp_id_string = Convert.ToString(reg.Match(available_emp));
                int emp_id = Convert.ToInt32(emp_id_string);
                string timeFrame = scheduleLogic.selectedTimeFrame(cbMorning.Checked, cbAfterNoon.Checked, cbEvening.Checked) ;
                if (timeFrame != "EVENING-MORNING")
                {
                    scheduleLogic.AssignShift(emp_id, date, timeFrame, departmentId); 
                    lbAvailableEmployees.Items.RemoveAt(lbAvailableEmployees.SelectedIndex);
                    PopulateGridSchedule();
                }
                cbMorning.Checked = false;
                cbEvening.Checked = false;
                cbAfterNoon.Checked = false;          
            }
            else
            {
                MessageBox.Show("Please pick an employee you would like to assign a shift of", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void PopulateGridSchedule() //oo
        {
            dataGridSchedule.Rows.Clear();
            dataGridSchedule.Refresh();
            string departmentName = cbScheduleDep.SelectedItem.ToString();
            int departmentId = departmentLogic.GetDepartmentId(departmentName);
            string date = Convert.ToString(datePickSchedule.Value.ToString("yyyy/MM/dd"));
            List<Shift> shifts = scheduleLogic.GetShifts(date, departmentId);
            int i = 0;
            dataGridSchedule.TopLeftHeaderCell.Value = "Employee Name";
            int rowAmount = scheduleLogic.GetShiftCountByDayWithValidEmployees(date, departmentId);
            if (rowAmount > 1) //avoiding extra rows and not enough rows    
            {
                rowAmount--;
                dataGridSchedule.Rows.Add(rowAmount);
            }
            dataGridSchedule.ClearSelection();
            foreach (Shift shift in shifts)
            {
                if(shift.EmployeeId == 0)
                {
                    scheduleLogic.DeleteShiftFromSchedule(shift.ShiftId);
                }
                else
                {
                    dataGridSchedule.Rows[i].HeaderCell.Value = employeesLogic.GetNameById(shift.EmployeeId);
                    scheduleColoring(shift.TimeFrame, i);
                }

                i++;

            }
        }

        public void scheduleColoring(string timeFrame, int i) // Used in PopulateGridSchedule
        {
            if (timeFrame == "MORNING")
            {
                dataGridSchedule.Rows[i].Cells[0].Style.BackColor = Color.Green;
            }
            if (timeFrame == "AFTERNOON")
            {
                dataGridSchedule.Rows[i].Cells[1].Style.BackColor = Color.Green;
            }
            if (timeFrame == "EVENING")
            {
                dataGridSchedule.Rows[i].Cells[2].Style.BackColor = Color.Green;
            }
            if (timeFrame == "MORNING-AFTERNOON")
            {
                dataGridSchedule.Rows[i].Cells[0].Style.BackColor = Color.Green;
                dataGridSchedule.Rows[i].Cells[1].Style.BackColor = Color.Green;
            }
            if (timeFrame == "MORNING-EVENING")
            {
                dataGridSchedule.Rows[i].Cells[0].Style.BackColor = Color.Green;
                dataGridSchedule.Rows[i].Cells[1].Style.BackColor = Color.Green;
                dataGridSchedule.Rows[i].Cells[2].Style.BackColor = Color.Green;
            }
            if (timeFrame == "AFTERNOON-EVENING")
            {
                dataGridSchedule.Rows[i].Cells[1].Style.BackColor = Color.Green;
                dataGridSchedule.Rows[i].Cells[2].Style.BackColor = Color.Green;
            }
        }

        public void PopulateEmployeeListGrid() //oo
        {
            int i = 0;
            dataGridEmpList.Rows.Clear();
            dataGridEmpList.Refresh();
            if (cbEmployeeStatusFIlter.SelectedItem == null)
            {
                cbEmployeeStatusFIlter.SelectedItem = "Status: Employed";
                dataGridEmpList.Columns.Add("columnEndDate", "End Date");
            }
            string cbFilter = cbEmployeeStatusFIlter.SelectedItem.ToString();
            if ((cbFilter == "Status: Retired") && (dataGridEmpList.Columns.Contains("columnEndDate")) == false)
            {
                dataGridEmpList.Columns.Add("columnEndDate", "End Date");
            }
            else if ((cbFilter == "Status: Employed") && (dataGridEmpList.Columns.Contains("columnEndDate")))
            {
                while (dataGridEmpList.Columns.Contains("columnEndDate"))
                {
                    dataGridEmpList.Columns.Remove("columnEndDate");
                }
            }
            List<Employee> employees = employeesLogic.GetEmployeeGridList(cbFilter);
            int employeeCount = employees.Count;
            if (employeeCount == 1)
            {
                employeeCount = 2;
            }
            else if (employeeCount > 1)
            {
                dataGridEmpList.Rows.Add((employeeCount) - 1);
            }
            PopulateEmployeeListGridLoop(employees, cbFilter, i);
        }

        public void PopulateEmployeeListGridLoop(List<Employee> employees, string cbFilter, int i) //Used in PopulateEmployeeListGrid() and ShowFoundEmployees()
        {
            foreach (Employee emp in employees)
            {
                if (user.GetRole() == "Admin")
                {
                    string salary = Convert.ToString(emp.Salary);
                    string hourlyWage = Convert.ToString(emp.Hourly_wage);

                    dataGridEmpList.Rows[i].Cells[0].Value = emp.EmployeeId;
                    dataGridEmpList.Rows[i].Cells[1].Value = emp.FirstName;
                    dataGridEmpList.Rows[i].Cells[2].Value = emp.LastName;
                    dataGridEmpList.Rows[i].Cells[3].Value = emp.Role;
                    dataGridEmpList.Rows[i].Cells[4].Value = departmentLogic.GetDepartmentName(emp.Department_id);
                    dataGridEmpList.Rows[i].Cells[5].Value = emp.Email;
                    dataGridEmpList.Rows[i].Cells[6].Value = emp.Phone;
                    dataGridEmpList.Rows[i].Cells[7].Value = salary;
                    dataGridEmpList.Rows[i].Cells[8].Value = hourlyWage;
                    dataGridEmpList.Rows[i].Cells[9].Value = emp.City;
                    dataGridEmpList.Rows[i].Cells[10].Value = emp.Street;
                    dataGridEmpList.Rows[i].Cells[11].Value = emp.HouseNumber;
                    dataGridEmpList.Rows[i].Cells[12].Value = emp.UserDOB;
                    dataGridEmpList.Rows[i].Cells[13].Value = emp.StartDate;
                    if (cbFilter == "Status: Retired")
                    {
                        dataGridEmpList.Rows[i].Cells[14].Value = emp.EndDate;
                    }
                    i++;
                }
                else
                {
                    if (emp.Role == "Admin" || emp.Role == "Manager")
                    {
                        dataGridEmpList.AllowUserToAddRows = false;
                        dataGridEmpList.Rows.RemoveAt(dataGridEmpList.Rows.Count - 1);
                        dataGridEmpList.AllowUserToAddRows = true;
                    }
                    else
                    {
                        string salary = Convert.ToString(emp.Salary);
                        string hourlyWage = Convert.ToString(emp.Hourly_wage);

                        dataGridEmpList.Rows[i].Cells[0].Value = emp.EmployeeId;
                        dataGridEmpList.Rows[i].Cells[1].Value = emp.FirstName;
                        dataGridEmpList.Rows[i].Cells[2].Value = emp.LastName;
                        dataGridEmpList.Rows[i].Cells[3].Value = emp.Role;
                        dataGridEmpList.Rows[i].Cells[4].Value = departmentLogic.GetDepartmentName(emp.Department_id);
                        dataGridEmpList.Rows[i].Cells[5].Value = emp.Email;
                        dataGridEmpList.Rows[i].Cells[6].Value = emp.Phone;
                        dataGridEmpList.Rows[i].Cells[7].Value = salary;
                        dataGridEmpList.Rows[i].Cells[8].Value = hourlyWage;
                        dataGridEmpList.Rows[i].Cells[9].Value = emp.City;
                        dataGridEmpList.Rows[i].Cells[10].Value = emp.Street;
                        dataGridEmpList.Rows[i].Cells[11].Value = emp.HouseNumber;
                        dataGridEmpList.Rows[i].Cells[12].Value = emp.UserDOB;
                        dataGridEmpList.Rows[i].Cells[13].Value = emp.StartDate;
                        if (cbFilter == "Status: Retired")
                        {
                            dataGridEmpList.Rows[i].Cells[14].Value = emp.EndDate;
                        }
                        i++;
                    }

                }

            }
        }
        private void btnSearchEmp_Click(object sender, EventArgs e) //oo
        {
            int i = 0;
            dataGridEmpList.Rows.Clear();   
            dataGridEmpList.Refresh();
            string lastName = tbEmpListSearch.Text;
            string cbFilter = cbEmployeeStatusFIlter.SelectedItem.ToString();
            List<Employee> employees = employeesLogic.SearchEmployeeByLastName(lastName, cbFilter);
            if (employees.Count > 1)
            {
                dataGridEmpList.Rows.Add((employees.Count) - 1);
            }
            PopulateEmployeeListGridLoop(employees, cbFilter, i);
        }

        public void PopulateListBox() //Populate Available employees listbox
        {
            lbAvailableEmployees.Items.Clear();
            string departmentName = cbScheduleDep.SelectedItem.ToString();
            int departmentId = departmentLogic.GetDepartmentId(departmentName);
            string date = Convert.ToString(datePickSchedule.Value.ToString("yyyy/MM/dd"));
            List<Employee> availableEmployees = employeesLogic.GetAvailableEmployees(departmentId, date);


            foreach (Employee emp in availableEmployees)
            {
                Holiday holiday = scheduleLogic.GetHoliday(emp.EmployeeId);
                if (holiday.GetEmployeeId() == 0 || !employeesLogic.HasLeave(holiday, date)) // holiday.GetEmployeeId() != 0 || employeesLogic.HasLeave(holiday, date)
                {
                    lbAvailableEmployees.Items.Add(emp.FirstName + " " + emp.LastName + " ID: " + Convert.ToString(emp.EmployeeId));      
                }
                else
                {
                    lbAvailableEmployees.Items.Add("UNAVAILABLE, " + emp.FirstName + " " + emp.LastName + " ID: " + Convert.ToString(emp.EmployeeId));
                }

            }
        }

        private void btnAddEmp_Click(object sender, EventArgs e) //Check after EmployeeForm has been refactored
        {
            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;
            string eMail = tbEmail.Text;
            string emp_DOB = Convert.ToString(dateTimeDOB.Value.ToString("yyyy/MM/dd"));
            int phone;
            string street = tbStreet.Text;
            int houseNr;
            string city = tbCity.Text;
            int department_id;
            double hourly_wage;
            double salary;
            string date = Convert.ToString(DateTime.UtcNow.ToString("yyyy/MM/dd"));
            string role;

            if (user.GetRole() == "Admin") // If user is an Admin
            {
                if (int.TryParse(tbPhone.Text, out phone))
                {
                    phone = Convert.ToInt32(tbPhone.Text);
                }
                else
                {
                    phone = -1;
                }

                if (int.TryParse(tbHouseNr.Text, out houseNr))
                {
                    houseNr = Convert.ToInt32(tbHouseNr.Text);
                }
                else
                {
                    houseNr = -1;
                }

                if (cbDepartment.SelectedIndex != -1)
                {
                    department_id = departmentLogic.GetDepartmentId(cbDepartment.Text);
                }
                else
                {
                    department_id = -1;
                }

                if (lblPay.Text == "Hourly Wage" && double.TryParse(tbMoney.Text, out hourly_wage))
                {
                    hourly_wage = Convert.ToDouble(tbMoney.Text);
                    salary = 0;
                }
                else if (double.TryParse(tbMoney.Text, out salary))
                {
                    salary = Convert.ToDouble(tbMoney.Text);
                    hourly_wage = 0;
                }
                else
                {
                    hourly_wage = -1;
                    salary = -1;
                }

                if (cbRole.SelectedIndex != -1)
                {
                    role = Convert.ToString(cbRole.SelectedItem);
                }
                else
                {
                    role = null;
                }

                if (VariableTester(firstName, lastName, street, city) && phone != -1 && houseNr != -1 && salary != -1 && hourly_wage != -1 && department_id != -1 && role != null)
                {
                    if (hourly_wage != 0)
                    {
                        salary = 0;
                    }
                    else
                    {
                        hourly_wage = 0;
                    }
                    employeesLogic.AddEmployee(firstName, lastName, eMail, emp_DOB, phone, street, houseNr, city, department_id, hourly_wage, salary, date, role);
                    PopulateEmployeeListGrid();
                    ClearTextboxes();
                }
                else
                {
                    MessageBox.Show("Please make sure your input values are correct.");
                }

            }
            else if(user.GetRole() == "Manager") //If user is a Manager
            {
                role = null;

                if (int.TryParse(tbPhone.Text, out phone))
                {
                    phone = Convert.ToInt32(tbPhone.Text);
                }
                else
                {
                    phone = -1;
                }

                if (int.TryParse(tbHouseNr.Text, out houseNr))
                {
                    houseNr = Convert.ToInt32(tbHouseNr.Text);
                }
                else
                {
                    houseNr = -1;
                }

                if (cbDepartment.SelectedIndex != -1)
                {
                    department_id = departmentLogic.GetDepartmentId(cbDepartment.Text); 
                }
                else
                {
                    department_id = -1;
                }

                if (lblPay.Text == "Hourly Wage" && double.TryParse(tbMoney.Text, out hourly_wage))
                {
                    hourly_wage = Convert.ToDouble(tbMoney.Text);
                    salary = 0;
                }
                else if (double.TryParse(tbMoney.Text, out salary))
                {
                    salary = Convert.ToDouble(tbMoney.Text);
                    hourly_wage = 0;
                }
                else
                {
                    hourly_wage = -1;
                    salary = -1;
                }

                if (cbRole.SelectedIndex != -1)
                {
                    if (cbRole.SelectedItem.ToString() == "Employee")
                    {
                        role = Convert.ToString(cbRole.SelectedItem);
                    }

                }

                if (VariableTester(firstName, lastName, street, city) && phone != -1 && houseNr != -1 && salary != -1 && hourly_wage != -1 && department_id != -1 && role != null)
                {
                    if (hourly_wage != 0)
                    {
                        salary = 0;
                    }
                    else
                    {
                        hourly_wage = 0;
                    }
                    employeesLogic.AddEmployee(firstName, lastName, eMail, emp_DOB, phone, street, houseNr, city, department_id, hourly_wage, salary, date, role);
                    PopulateEmployeeListGrid();
                    ClearTextboxes();
                }
                else if(role != "employee")
                {
                    MessageBox.Show("Managers can only add employees", "Invalid role", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Please make sure your input values are correct.", "Invalid values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // If user is neither an Admin or Manager
            {
                MessageBox.Show("You don't have access to this function!");
            }
            
        }

        public bool VariableTester(string firstName, string lastName, string street, string city) //Used in AddEmployee
        {
            bool outcome = true;
            if (!Regex.IsMatch(firstName, @"^[a-zA-Z]+$"))
            {
                outcome = false;
            }
            if(!Regex.IsMatch(lastName, @"^[a-zA-Z]+$"))
            {
                outcome = false;
            }
            if(!Regex.IsMatch(city, @"^[a-zA-Z]+$"))
            {
                outcome = false;
            }

            return outcome;
        }

        private void ClearTextboxes() //Used in AddEmployee
        {
            tbFirstName.Clear();
            tbLastName.Clear();
            tbEmail.Clear();
            tbPhone.Clear();
            tbStreet.Clear();
            tbHouseNr.Clear();
            tbCity.Clear();
            tbMoney.Clear();
        }

        private void btnRemoveEmp_Click(object sender, EventArgs e) //oo
        {
            if (user.GetRole() == "Admin")
            {
                int emp_id = Convert.ToInt32(dataGridEmpList.CurrentRow.Cells[0].Value);
                string first_name = Convert.ToString(dataGridEmpList.CurrentRow.Cells[1].Value);
                string last_name = Convert.ToString(dataGridEmpList.CurrentRow.Cells[2].Value);

                if (emp_id == user.GetID())
                {
                    MessageBox.Show("You can not delete the account you are currently logged into!");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete {first_name} {last_name} from the database? ", "Delete employee", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dialogResult == DialogResult.Yes)
                    {
                        employeesLogic.RemoveEmployee(emp_id);
                        PopulateEmployeeListGrid();
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }

                }
            }
            else if(user.GetRole() == "Manager")
            {
                int emp_id = Convert.ToInt32(dataGridEmpList.CurrentRow.Cells[0].Value);
                string first_name = Convert.ToString(dataGridEmpList.CurrentRow.Cells[1].Value);
                string last_name = Convert.ToString(dataGridEmpList.CurrentRow.Cells[2].Value);

                if (emp_id == user.GetID())
                {
                    MessageBox.Show("You can not delete the account you are currently logged into!");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete {first_name} {last_name} from the database? ", "Delete employee", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dialogResult == DialogResult.Yes)
                    {
                        employeesLogic.RemoveEmployee(emp_id);
                        PopulateEmployeeListGrid();
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }

                }
            }
            else
            {
                MessageBox.Show("You don't have access to this function.");
            }
        }

        private void btnEditEmpInfo_Click(object sender, EventArgs e) //oo
        {
            
            if(tcEmpList.SelectedTab != tabEditEmployee)
            {
                PopulateTextBoxes();
            }
            else if (tcEmpList.SelectedTab == tabEditEmployee)
            {
                MessageBox.Show("Please finish your edit first.", "Edit employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void PopulateTextBoxes() //oo
        {
            tcEmpList.TabPages.Add(tabEditEmployee);
            tcEmpList.SelectedTab = tabEditEmployee;
            int employeeId = Convert.ToInt32(dataGridEmpList.CurrentRow.Cells[0].Value);
            Employee emp = employeesLogic.GetSingleEmployee(employeeId);

            lblEditId.Text = Convert.ToString(emp.EmployeeId);
            tbFirstNameEdit.Text = emp.FirstName;
            tbLastNameEdit.Text = emp.LastName;
            cbDepartmentEdit.SelectedItem = departmentLogic.GetDepartmentName(emp.Department_id);
            tbEmailEdit.Text = emp.Email;
            dateTimeDOBEdit.Value = Convert.ToDateTime(emp.UserDOB);
            tbPhoneEdit.Text = Convert.ToString(emp.Phone);
            tbCityEdit.Text = emp.City;
            tbStreetEdit.Text = Convert.ToString(emp.Street);
            tbHouseNumberEdit.Text = Convert.ToString(emp.HouseNumber);
            tbMoneyEdit.Text = Convert.ToString(emp.Salary);

            if(emp.Role == "Employee")
            {
                lblEditPay.Text = "Hourly Wage";
                lblEmpRole.Text = "Employee";
            }
            else if(emp.Role == "Manager")
            {
                lblEditPay.Text = "Wage";
                lblEmpRole.Text = "Manager";
            }
            else
            {
                lblEditPay.Text = "Wage";
                lblEmpRole.Text = "Admin";
            }
        }

        private void btnFinishEdit_Click(object sender, EventArgs e) //oo
        {
            int emp_id = Convert.ToInt32(lblEditId.Text);
            string firstName = tbFirstNameEdit.Text;
            string lastName = tbLastNameEdit.Text;
            string eMail = tbEmailEdit.Text;
            string emp_DOB = Convert.ToString(dateTimeDOBEdit.Value.ToString("yyyy/MM/dd"));
            int phone = Convert.ToInt32(tbPhoneEdit.Text);
            string street = tbStreetEdit.Text;
            int houseNr = Convert.ToInt32(tbHouseNumberEdit.Text);
            string city = tbCityEdit.Text;
            int department_id = departmentLogic.GetDepartmentId(cbDepartmentEdit.Text);
            int hourly_wage = Convert.ToInt32(tbMoneyEdit.Text);

            employeesLogic.UpdateEmployee(emp_id, firstName, lastName, eMail, emp_DOB, phone, street, houseNr, city, department_id, hourly_wage);
            PopulateEmployeeListGrid();
            tcEmpList.TabPages.Remove(tabEditEmployee);
            MessageBox.Show("Edit successful");
        }

        public void PopulateRoleCb() //oo
        {
            foreach(string role in employeesLogic.GetRoles())
            {
                cbRole.Items.Add(role);
            }

            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e) //oo
        {
            string role = Convert.ToString(cbRole.SelectedItem);
            if (role == "Employee")
            {
                lblPay.Text = "Hourly Wage";
            }
            else
            {
                lblPay.Text = "Salary";
            }
        }

        

        private void btnRetireEmployee_Click(object sender, EventArgs e) //oo
        {
            int emp_id = Convert.ToInt32(dataGridEmpList.CurrentRow.Cells[0].Value);
            Employee emp = employeesLogic.GetSingleEmployee(emp_id);

            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to retire {emp.FirstName} {emp.LastName} ? ", "Retire employee", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                string retire_date = dpRetireEmployee.Value.ToString("yyyy/MM/dd");

                string emp_DOB = Convert.ToDateTime(emp.UserDOB).ToString("yyyy/MM/dd");
                string start_date = Convert.ToDateTime(emp.StartDate).ToString("yyyy/MM/dd");
                employeesLogic.RetireEmployee(retire_date, emp_id);
                employeesLogic.AddRetirementHistory(emp.EmployeeId, emp.FirstName, emp.LastName, emp.Email, emp_DOB, emp.Phone, emp.Street, emp.HouseNumber, emp.City, emp.Department_id, start_date, retire_date, emp.Role);
                PopulateEmployeeListGrid();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btnEditSchedule_Click(object sender, EventArgs e) 
        {
            btnScheduleAssignEmp.Hide();
            btnFinishScheduleEdit.Show();
            int departmentId = departmentLogic.GetDepartmentId(cbScheduleDep.SelectedItem.ToString());
            string date = Convert.ToString(datePickSchedule.Value.ToString("yyyy/MM/dd"));
            List<Shift> shifts = scheduleLogic.GetShifts(date, departmentId);
            foreach (Shift shift in shifts)
            {
                if (employeesLogic.GetNameById(shift.EmployeeId) == Convert.ToString(dataGridSchedule.CurrentRow.HeaderCell.Value))
                {
                    lbAvailableEmployees.Items.Clear();
                    lbAvailableEmployees.Items.Add(employeesLogic.GetNameById(shift.EmployeeId));
                    lbAvailableEmployees.SelectedIndex = 0;
                    TimeFrameSelect(shift.TimeFrame);
                }
            }

        }

        public void TimeFrameSelect(string timeFrame) //Used in EditSchedule
        {
            cbAfterNoon.Checked = false;
            cbMorning.Checked = false;
            cbEvening.Checked = false;

            if(timeFrame == "MORNING-EVENING")
            {
                cbMorning.Checked = true;
                cbAfterNoon.Checked = true;
                cbEvening.Checked = true;
            }
            else if(timeFrame == "MORNING-AFTERNOON")
            {
                cbMorning.Checked = true;
                cbAfterNoon.Checked = true;
            }
            else if(timeFrame == "AFTERNOON-EVENING")
            {
                cbAfterNoon.Checked = true;
                cbEvening.Checked = true;
            }
            else if (timeFrame == "MORNING")
            {
                cbMorning.Checked = true;
            }
            else if (timeFrame == "AFTERNOON")
            {
                cbAfterNoon.Checked = true;
            }
            else
            {
                cbEvening.Checked = true;
            }

        }

        private void btnFinishScheduleEdit_Click(object sender, EventArgs e) //oo
        {
            try
            {
                string departmentName = cbScheduleDep.SelectedItem.ToString();

                int departmentId = departmentLogic.GetDepartmentId(departmentName);
                string date = Convert.ToString(datePickSchedule.Value.ToString("yyyy/MM/dd"));
                string timeFrame = scheduleLogic.selectedTimeFrame(cbMorning.Checked, cbAfterNoon.Checked, cbEvening.Checked);
                List<Shift> shifts = scheduleLogic.GetShifts(date, departmentId);
                foreach (Shift shift in shifts)
                {
                    if (employeesLogic.GetNameById(shift.EmployeeId) == Convert.ToString(dataGridSchedule.CurrentRow.HeaderCell.Value))
                    {
                        if (timeFrame != "EVENING-MORNING")
                        {
                            scheduleLogic.UpdateShift(timeFrame, shift.EmployeeId, date);
                        }
                        
                        PopulateListBox();
                    }
                }
                PopulateGridSchedule();
                btnScheduleAssignEmp.Show();
                btnFinishScheduleEdit.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Something went wrong {ex.Message}");
            }
            finally
            {
                PopulateGridSchedule();
                btnScheduleAssignEmp.Show();
                btnFinishScheduleEdit.Hide();
                cbAfterNoon.Checked = false;
                cbMorning.Checked = false;
                cbEvening.Checked = false;
            }
        }

        private void cbEmployeeStatusFIlter_SelectedIndexChanged(object sender, EventArgs e) //oo
        {
            if(cbEmployeeStatusFIlter.SelectedItem.ToString() == "Status: Retired")
            {
                btnReHire.Show();
                btnRetireEmployee.Hide();
                PopulateEmployeeListGrid();
            }
            else if(btnReHire.Visible) // check if its the initial launch of employeeTab
            {                
                btnRetireEmployee.Show();
                btnReHire.Hide();
                PopulateEmployeeListGrid();
            }
        }

        private void btnReHire_Click(object sender, EventArgs e) //oo
        {
            //gotta implement not allowing an employee getting retired multiple times while they are still in the employee list.
            //Maybe will work with checking if end date is null or not
            int emp_id = Convert.ToInt32(dataGridEmpList.CurrentRow.Cells[0].Value);
            string rehire_date = dpRetireEmployee.Value.ToString("yyyy/MM/dd");
            employeesLogic.RehireEmployee(rehire_date, emp_id);
            PopulateEmployeeListGrid();
        }

        private void EmployeesForm_FormClosed(object sender, FormClosedEventArgs e) //oo
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        private void btnHomeMenu_Click(object sender, EventArgs e) //oo
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

        private void btnStckMenu_Click(object sender, EventArgs e)//oo
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

        private void btnDepMenu_Click(object sender, EventArgs e)//oo
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

        private void btnLogOut_Click(object sender, EventArgs e) //oo
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

        private void btnExportSchedulePDF_Click(object sender, EventArgs e)
        {
            if (cbScheduleDep.SelectedItem == null)
            {
                MessageBox.Show("Please pick a department.", "Department", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
            else
            {
                string date = Convert.ToString(datePickSchedule.Value.ToString("yyyy-MM-dd"));
                string departmentName = cbScheduleDep.SelectedItem.ToString();
                int departmentId = departmentLogic.GetDepartmentId(departmentName);

                pDFGenerator.GenerateSchedulePDF(date, departmentId);
            }
        }

        private void btnAcceptHolidayRequest_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"(?<=Employee.ID:.)\w+");
            int employeeId = Convert.ToInt32(Convert.ToString(regex.Match(lbEmployeeHolidayRequests.SelectedItem.ToString()))); 
            Holiday holiday = scheduleLogic.GetHoliday(employeeId);
            holiday.Status = "accepted";
            scheduleLogic.RespondHolidayRequest(holiday);
            PopulateHolidayRequests();
        }

        private void btnDenyHolidayRequest_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"(?<=Employee.ID:.)\w+");
            int employeeId = Convert.ToInt32(Convert.ToString(regex.Match(lbEmployeeHolidayRequests.SelectedItem.ToString())));
            Holiday holiday = scheduleLogic.GetHoliday(employeeId);
            holiday.Status = "denied"; 
            scheduleLogic.RespondHolidayRequest(holiday);
            PopulateHolidayRequests();
        }
    }
}
