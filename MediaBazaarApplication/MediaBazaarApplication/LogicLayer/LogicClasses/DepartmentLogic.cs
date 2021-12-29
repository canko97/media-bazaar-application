using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MediaBazaarApplication
{
    public class DepartmentLogic
    {
        DBDepartment departmentDB = new DBDepartment();


        public int GetDepartmentId(string departmentName)
        {
            return departmentDB.GetDepartmentId(departmentName);
        }



        public List<string> GetDepNames()
        {
            return departmentDB.GetDepartmentNames();
        }



        public string GetDepartmentName(int departmentId)
        {
            return departmentDB.GetDepartmentName(departmentId);
        }


        public DataTable GetAllDepartments()
        {
            DataTable dTBL = new DataTable();
            departmentDB.GetAllDepartments().Fill(dTBL);
            return dTBL;
        }

        public void AddDepartment(string departmentName)
        {
            departmentDB.AddDepartment(departmentName);
        }

        public void EditDepartment(int departmentId, string departmentName)
        {
            departmentDB.EditDepartment(departmentId, departmentName);
        }

        public void DeleteDepartment(int departmentId)
        {
            departmentDB.DeleteDepartment(departmentId);
        }

        public void AssignManagerToDepartment(int managerId, int departmentId)
        {
            departmentDB.AssignManagerToDepartment(managerId, departmentId);
        }

        public void ResignManager(int employeeId, int departmentId)
        {
            departmentDB.ResignManager(employeeId, departmentId);
        }

    }
}
