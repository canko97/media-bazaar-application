<?php
include_once("../includes/data/DepartmentDB.php");
require_once("Base Classes/department.php");
class DepartmentLogic
{
    public static function GetDepartmentIdByName($name)
    {
        $found_department = DepartmentDB::GetDepartmentIdByName($name);
        echo $found_department["department_id"];
    }

    public static function GetDepartmentById($id)
    {
        $found_department = DepartmentDB::GetDepartmentById($id);

        $department = new Department($found_department["department_id"], $found_department["department_name"]);

        return $department;
    }

    public static function EchoAllDepartments($id)
    {
        $result_set = DepartmentDB::GetAllDepartments($id);
        $defaultDepartmentName = DepartmentLogic::GetDepartmentById($id)->GetDepartmentName();
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
?>