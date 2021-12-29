<?php

class UserDB
{
    public static function FindAllUsers()
    {
        global $database;
        $result_set = $database->query("SELECT * FROM employees");
        return $result_set;
    }

    public static function GetUserById($user_id)
    {
        global $database;
        $result_set = $database->query("SELECT * FROM employees WHERE emp_id = '$user_id'");
        $found_user = mysqli_fetch_array($result_set);
   
        return $found_user;
    }
    public static function GetUsersPassword($email)
    {
        global $database;
        $result_set = $database->query("SELECT password FROM employees WHERE email = '$email'");
        $found_user = mysqli_fetch_array($result_set);

        return $found_user;
    }
    public static function GetNameById($id)
    {
        global $database;
        $result_set = $database->query("select concat(first_name, \" \", last_name) as name from employees where emp_id = $id");
        $found_user = mysqli_fetch_array($result_set);
   
        return $found_user;
    }
    public static function GetUserByEmail($email)
    {
        global $database;
        $result_set = $database->query("SELECT * FROM employees WHERE email = '$email'");
        $found_user = mysqli_fetch_array($result_set);

        return $found_user;
    }
    public function CreateNewUser($firstName, $lastName, $email, $password, $DOB, $phone, $street, $houseNr, $city, $departmentId, $hourlyWage, $salary, $startDate, $endDate, $role)
    {
        global $database;
   
        $sql = "INSERT INTO employees (first_name, last_name, email, password, emp_DOB, phone, street, house_nr, city, department_id, hourly_wage, salary, start_date, end_date, role) ";
        $sql .= "VALUES ('";
        $sql .= $database->escape_string($firstName) . "', '";
        $sql .= $database->escape_string($lastName) . "', '";
        $sql .= $database->escape_string($email) . "', '";
        $sql .= $database->escape_string($password) . "', '";
        $sql .= $database->escape_string($DOB) . "', '";
        $sql .= $database->escape_string($phone) . "', '";
        $sql .= $database->escape_string($street) . "', '";
        $sql .= $database->escape_string($houseNr) . "', '";
        $sql .= $database->escape_string($city) . "', '";
        $sql .= $database->escape_string($departmentId) . "', '";
        $sql .= $database->escape_string($hourlyWage) . "', '";
        $sql .= $database->escape_string($salary) . "', '";
        $sql .= $database->escape_string($startDate) . "', '";
        $sql .= $database->escape_string($endDate) . "', '";
        $sql .= $database->escape_string($role) . "')";
   
        $database->query($sql);
   
    }
   
    public function UpdateUserInfo($emp_id, $firstName, $lastName, $email, $password, $DOB, $phone, $street, $houseNr, $city, $departmentId, $hourlyWage, $salary, $startDate, $endDate, $role)
    {
        global $database;
   
        $sql = "Update employees SET ";
        $sql .= "first_name = '" . $database->escape_string($firstName) . "', ";
        $sql .= "last_name = '" . $database->escape_string($lastName) . "', ";
        $sql .= "email = '" . $database->escape_string($email) . "', ";
        $sql .= "password = '" . $database->escape_string($password) . "', ";
        $sql .= "emp_DOB = '" . $database->escape_string($DOB) . "', ";
        $sql .= "phone = " . $database->escape_string($phone) . ", ";
        $sql .= "street = '" . $database->escape_string($street) . "', ";
        $sql .= "house_nr = " . $database->escape_string($houseNr) . ", ";
        $sql .= "city = '" . $database->escape_string($city) . "', ";
        $sql .= "department_id = " . $database->escape_string($departmentId) . ", ";
        $sql .= "hourly_wage = " . $database->escape_string($hourlyWage) . ", ";
        $sql .= "salary = " . $database->escape_string($salary) . ", ";
        $sql .= "start_date = '" . $database->escape_string($startDate) . "', ";
        $sql .= "end_date = NULL, ";
        $sql .= "role = '" . $database->escape_string($role) . "' ";
        $sql .= "WHERE emp_id = " . $emp_id;
   
        $database->query($sql);
   
    }
}

?>