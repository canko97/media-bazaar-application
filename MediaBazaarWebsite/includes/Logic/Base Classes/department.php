<?php

class Department{
    private $department_id;
    private $department_name;

    public function __construct($department_id, $department_name)
    {
        $this->department_id = $department_id;
        $this->department_name = $department_name;
    }

    public function GetDepartmentID(){
        return $this->department_id;
    }

    public function GetDepartmentName(){
        return $this->department_name;
    }

    public static function GetDepartmentIdByName($name){
        global $database;
        $result_set = $database->query("SELECT * FROM departments WHERE department_name = '$name'");
        $found_department = mysqli_fetch_array($result_set);

        echo $found_department["department_id"];
    }


    public static function GetDepartmentById($id)
    {
        global $database;
        $result_set = $database->query("SELECT * FROM departments WHERE department_id = '$id'");
        $found_department = mysqli_fetch_array($result_set);

        $department = new Department($found_department["department_id"], $found_department["department_name"]);

        return $department;
    }

    public static function EchoAllDepartments($id)
    {
        global $database;
        $result_set = $database->query("SELECT * FROM departments");
        $defaultDepartmentName = Department::GetDepartmentById($id)->GetDepartmentName();
        echo '<option selected="selected" value=" ' . "$id" . '">'. "$defaultDepartmentName" . '</option>';
        foreach ($result_set as $department){
            if($department["department_id"] != $id){
                $department_id = $department["department_id"];
                $department_name = $department["department_name"];
                echo '<option value=" ' . "$department_id" . '">'. "$department_name" . '</option>';
            }
        }
    }
}
