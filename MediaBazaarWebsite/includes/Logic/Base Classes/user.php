<?php

class User
{
    private int $emp_id;
    private string $first_name;
    private string $last_name;
    private string $email;
    private string $password;
    private string $emp_DOB;
    private int $phone;
    private string $street;
    private int $house_nr;
    private string $city;
    private int $department_id;
    private float $hourly_wage;
    private float $salary;
    private string $start_date;
    private string $end_date;
    private string $role;

    function __construct(int $emp_id,
                         string $first_name,
                         string $last_name,
                         string $email,
                         string $password,
                         string $emp_DOB,
                         int $phone,
                         string $street,
                         int $house_nr,
                         string $city,
                         int $department_id,
                         float $hourly_wage,
                         float $salary,
                         string $start_date,
                         string $end_date,
                         string $role)
    {
        $this->emp_id = $emp_id;
        $this->first_name = $first_name;
        $this->last_name = $last_name;
        $this->email = $email;
        $this->password = $password;
        $this->emp_DOB = $emp_DOB;
        $this->phone = $phone;
        $this->street = $street;
        $this->house_nr = $house_nr;
        $this->city = $city;
        $this->department_id = $department_id;
        $this->hourly_wage = $hourly_wage;
        $this->salary = $salary;
        $this->start_date = $start_date;
        $this->end_date = $end_date;
        $this->role = $role;
    }

    public function GetId()
    {
        return $this->emp_id;
    }
    public function GetFirstName()
    {
        return $this->first_name;
    }
    public function GetLastName()
    {
        return $this->last_name;
    }
    public function GetEmail()
    {
        return $this->email;
    }
    public function GetPassword()
    {
        return $this->password;
    }
    public function GetDOB()
    {
        return $this->emp_DOB;
    }
    public function GetPhone()
    {
        return $this->phone;
    }
    public function GetStreet()
    {
        return $this->street;
    }
    public function GetHouseNr()
    {
        return $this->house_nr;
    }
    public function GetCity()
    {
        return $this->city;
    }
    public function GetDepartmentId()
    {
        return $this->department_id;
    }
    public function GetHourlyWage()
    {
        return $this->hourly_wage;
    }
    public function GetSalary()
    {
        return $this->salary;
    }
    public function GetStarDate()
    {
        return $this->start_date;
    }
    public function GetEndDate()
    {
        return $this->end_date;
    }
    public function GetRole()
    {
        return $this->role;
    }
}

?>