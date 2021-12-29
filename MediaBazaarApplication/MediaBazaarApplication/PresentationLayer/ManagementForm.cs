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
    public partial class ManagementForm : Form
    {
        Department department;
        EmployeesLogic employeesLogic;
        DepartmentLogic departmentLogic;

        public ManagementForm(Employee user, Department department)
        {
            InitializeComponent();
            this.department = department;
            lblDepartment.Text = department.GetName();
            employeesLogic = new EmployeesLogic();
            departmentLogic = new DepartmentLogic();
            PopulateManagersDGV();
            PopulateManagersOfThisDepartmentDGV();
        }

        private void btnAssign_Click(object sender, EventArgs e) //oo
        {
            int manager_id = Convert.ToInt32(dgvManagers.CurrentRow.Cells[0].Value);
            int department_id = department.GetId();
            departmentLogic.AssignManagerToDepartment(manager_id, department_id);
            PopulateManagersDGV();
            PopulateManagersOfThisDepartmentDGV();
        }

        public void PopulateManagersDGV() //oo
        {
            int i = 0;
            dgvManagers.Rows.Clear();
            dgvManagers.Refresh();
            List<Employee> managers = employeesLogic.GetUnassignedManagers(department.GetId());
            if (managers.Count > 0)
            {
                dgvManagers.Rows.Add(managers.Count);
                foreach (Employee manager in managers)
                {
                    dgvManagers.Rows[i].Cells[0].Value = manager.EmployeeId;
                    dgvManagers.Rows[i].Cells[1].Value = manager.FirstName;
                    dgvManagers.Rows[i].Cells[2].Value = manager.LastName;
                    i++;
                }
            }
        }

        public void PopulateManagersOfThisDepartmentDGV() //oo
        {
            int i = 0;
            dgvManagersOfThisDepartment.Rows.Clear();
            dgvManagersOfThisDepartment.Refresh();
            List<Employee> managers = employeesLogic.GetManagersOfDepartment(department.GetId());
            if (managers.Count > 0)
            {
                dgvManagersOfThisDepartment.Rows.Add((managers.Count));
                foreach (Employee manager in managers)
                {
                    dgvManagersOfThisDepartment.Rows[i].Cells[0].Value = manager.EmployeeId;
                    dgvManagersOfThisDepartment.Rows[i].Cells[1].Value = manager.FirstName;
                    dgvManagersOfThisDepartment.Rows[i].Cells[2].Value = manager.LastName;
                    i++;
                }
            }
        }

        private void btnResignManager_Click(object sender, EventArgs e) //oo
        {
            int emp_id = Convert.ToInt32(dgvManagersOfThisDepartment.CurrentRow.Cells[0].Value);
            int department_id = department.GetId();
            departmentLogic.ResignManager(emp_id, department_id);
            PopulateManagersDGV();
            PopulateManagersOfThisDepartmentDGV();
        }
    }
}
