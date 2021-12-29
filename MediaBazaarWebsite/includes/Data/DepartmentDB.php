<?php
class DepartmentDB
{
    public static function GetDepartmentIdByName($name)
    {
        global $database;
        $result_set = $database->query("SELECT * FROM departments WHERE department_name = '$name'");
        $found_department = mysqli_fetch_array($result_set);

        return $found_department;
    }

    public static function GetDepartmentById($id)
    {
        global $database;
        $result_set = $database->query("SELECT * FROM departments WHERE department_id = '$id'");
        $found_department = mysqli_fetch_array($result_set);

        return $found_department;
    }

    public static function GetAllDepartments($id)
    {
        global $database;
        $result_set = $database->query("SELECT * FROM departments");
        return $result_set;
    }
}
?>