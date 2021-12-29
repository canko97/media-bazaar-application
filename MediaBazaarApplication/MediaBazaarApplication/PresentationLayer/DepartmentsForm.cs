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
    
    public partial class DepartmentsForm : Form
    {
        Employee user;
        DepartmentLogic departmentLogic;
        EmployeesLogic employeesLogic;

        public DepartmentsForm(Employee user)
        {
            this.user = user;
            InitializeComponent();
            departmentLogic = new DepartmentLogic();
            employeesLogic = new EmployeesLogic();
            PopulateGrid();
            lblUserLastName.Text = Convert.ToString(user.GetName());
            lblLoggedInUserRole.Text = Convert.ToString(user.GetRole()) + " account";
        }

        public void PopulateGrid() //oo
        {
            dgvDepartments.DataSource = departmentLogic.GetAllDepartments();
        }

        private void dgvDepartments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dgvDepartments.CurrentRow.Index;
            tbDepartmentName.Text = Convert.ToString(dgvDepartments.Rows[rowIndex].Cells[1].Value);
        }

        private void btnAdd_Click(object sender, EventArgs e) //oo
        {
            if(user.GetRole()=="Admin")
            {
                departmentLogic.AddDepartment(tbDepartmentName.Text);
                tbDepartmentName.Clear();
                PopulateGrid();
            }
            else
            {
                MessageBox.Show("You don't have access to this function!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e) //oo
        {
            if (user.GetRole() == "Admin")
            {
                int rowIndex = dgvDepartments.CurrentRow.Index;
                int departmentId = Convert.ToInt32(dgvDepartments.Rows[rowIndex].Cells[0].Value);
                departmentLogic.EditDepartment(departmentId, tbDepartmentName.Text);
                PopulateGrid();
            }
            else
            {
                MessageBox.Show("You don't have access to this function!");
            }
            
        }

        private void btnRemove_Click(object sender, EventArgs e) //oo
        {
            if (user.GetRole() == "Admin")
            {
                int rowIndex = dgvDepartments.CurrentRow.Index;
                int departmentId = Convert.ToInt32(dgvDepartments.Rows[rowIndex].Cells[0].Value);
                bool populated = DisableRemoval(departmentId);
                if (populated)
                {
                    MessageBox.Show("Sorry, you cannot remove a department with employees in it.");
                }
                else
                {
                    departmentLogic.DeleteDepartment(departmentId);
                    PopulateGrid();
                }
            }
            else
            {
                MessageBox.Show("You don't have access to this function!");
            }
            
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

        private void DepartmentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        public bool DisableRemoval(int dep_id) //oo
        {
            bool populated = false;
            List<Employee> employees = employeesLogic.GetAllActiveEmployees();
            foreach(Employee employee in employees)
            {
                if(employee.Department_id == dep_id)
                {
                    populated = true;
                }
            }
            return populated;
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btnAssignManager_Click(object sender, EventArgs e)
        {
            int dep_id = Convert.ToInt32(dgvDepartments.CurrentRow.Cells[0].Value);
            string dep_name = Convert.ToString(dgvDepartments.CurrentRow.Cells[1].Value);
            Department selectedDepartment = new Department(dep_id, dep_name);
            ManagementForm form = new ManagementForm(user, selectedDepartment);
            form.Show();
        }
    }
}
