using MediaBazaarApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarUnitTestProject
{
    public static class _TestDataHelper
    {

        public static Employee GenerateEmployeeA()
        {
            return new Employee(3, "Jane", "Deer", "jane@email.com", "jane", "2020-10-09", 613432214, "Keten", 2, "Eindhoven", 2, 0.00, 0.00, "2020-10-09", null, "Employee");
        }
        public static Employee GenerateEmployeeB()
        {
            return new Employee(31, "Lijsbeth", "Rodolf", "rodolf@email.com", "rodolf", "1979-12-03", 645928398, "Salt", 15, "Amsterdam", 4, 0.00, 0.00, "2020-10-09", "2020-11-01", "Employee");
        }
        public static Employee GenerateEmployeeC()
        {
            return new Employee(32, "Regina", "Filangee", "reginafilangee@email.com", "regina", "1993-10-20", 456123452, "Pepper", 17, "Eindhoven", 17, 0.00, 0.00, "2020-10-09", null, "Employee");
        }
        public static Employee GenerateEmployeeD()
        {
            return new Employee(33, "Josh", "Ford", "joshford@email.com", "josh", "1989-01-19", 689255893, "Kurhaus", 22, "TheHague", 4, 0.00, 0.00, "2020-10-09", "2020-11-28", "Employee");
        }

    }
}
