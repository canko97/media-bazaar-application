using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApplication
{
    public class Employee
    {

        protected int id;
        protected string firstName;
        protected string lastName;
        protected string email;
        protected string password;
        protected string empDOB;
        protected int phone;
        protected string street;
        protected int houseNumber;
        protected string city;
        protected string startDate;
        protected string endDate;
        protected int departmentId;
        protected double hourly_wage;
        protected double salary;
        protected string role;


        public Employee(int employeeId, string firstName, string lastName)
        {
            this.EmployeeId = employeeId;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Employee(int id, string firstName, string lastName, string eMail, string password, string userDOB, int phone, string street, int houseNumber, string city, int department_id, double hourly_wage, double salary, string startDate, string role)
        {
            EmployeeId = id;
            FirstName = firstName;
            LastName = lastName;
            Email = eMail;
            Password = password;
            UserDOB = userDOB;
            Phone = phone;
            Street = street;
            HouseNumber = houseNumber;
            City = city;
            Department_id = department_id;
            Hourly_wage = hourly_wage;
            Salary = salary;
            StartDate = startDate;
            Role = role;
        }

        public Employee(int id, string firstName, string lastName, string eMail, string password, string userDOB, int phone, string street, int houseNumber, string city, int department_id, double hourly_wage, double salary, string startDate, string endDate, string role)
        {
            EmployeeId = id;
            FirstName = firstName;
            LastName = lastName;
            Email = eMail;
            Password = password;
            UserDOB = userDOB;
            Phone = phone;
            Street = street;
            HouseNumber = houseNumber;
            City = city;
            Department_id = department_id;
            Hourly_wage = hourly_wage;
            Salary = salary;
            StartDate = startDate;
            EndDate = endDate;
            Role = role;
        }

        public Employee(int id,
                        string firstName,
                        string lastName,
                        string email,
                        string password,
                        string empDOB,
                        int phone,
                        string street,
                        int houseNumber,
                        string city,
                        int departmentId,
                        double hourly_wage,
                        double salary,
                        string role)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
            this.empDOB = empDOB;
            this.phone = phone;
            this.street = street;
            this.houseNumber = houseNumber;
            this.city = city;
            this.departmentId = departmentId;
            this.hourly_wage = hourly_wage;
            this.salary = salary;
            this.role = role;
        }
        

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserDOB { get; set; }
        public int Phone { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public string City { get; set; }
        public int Department_id { get; set; }
        public double Hourly_wage { get; set; }
        public double Salary { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Role { get; set; }
            


        #region Get Methods
        public int GetID()
        {
            return this.id;
        }
        public string GetFirstName()
        {
            return this.firstName;
        }
        public string GetLastName()
        {
            return this.lastName;
        }
        public string GetEmail()
        {
            return this.email;
        }
        public string GetPassword()
        {
            return this.password;
        }
        public string EmpDOB()
        {
            return this.empDOB;
        }
        public int GetPhone()
        {
            return this.phone;
        }
        public string GetStreet()
        {
            return this.street;
        }
        public int GetHouseNr()
        {
            return this.houseNumber;
        }

        public string GetCity()
        {
            return this.city;
        }

        public int GetDepartmentId()
        {
            return this.departmentId;
        }
        public double GetHourlyWage()
        {
            return this.hourly_wage;
        }
        public double GetSalary()
        {
            return this.salary;
        }
        public string GetStartDate()
        {
            return this.startDate;
        }

        public string GetRole()
        {
            return this.role;
        }
        public string GetName()
        {
            return $"{firstName} {lastName}";
        }
        #endregion

    }
}
