using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApplication
{
    public class Department
    {

        private int departmentId;
        private string departmentName;

        public Department(int departmentId, string departmentName)
        {
            this.departmentId = departmentId;
            this.departmentName = departmentName;
        }
        
        public string GetName()
        {
            return departmentName;
        }

        public int GetId()
        {
            return departmentId;
        }

    }
}
