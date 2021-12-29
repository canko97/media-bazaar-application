<?php
include_once("../includes/data/UserDB.php");
require_once("Base Classes/user.php");
class UserLogic
{
 public function FindAllUsers()
 {
     $result_set = UserDB::FindAllUsers();
     return $result_set;
 }

 public static function GetUserById($user_id)
 {
     $found_user = UserDB::GetUserById($user_id);

     $user = new User($found_user["emp_id"], $found_user["first_name"], $found_user["last_name"], $found_user["email"], $found_user["password"], $found_user["emp_DOB"], $found_user["phone"], $found_user["street"], $found_user["house_nr"], $found_user["city"], $found_user["department_id"], $found_user["hourly_wage"], $found_user["salary"], $found_user["start_date"], 0, $found_user["role"],);

     return $user;
 }

 public static function GetUserByEmail($email)
 {
     $found_user = UserDB::GetUserByEmail($email);

     $user = new User($found_user["emp_id"], $found_user["first_name"], $found_user["last_name"], $found_user["email"], $found_user["password"], $found_user["emp_DOB"], $found_user["phone"], $found_user["street"], $found_user["house_nr"], $found_user["city"], $found_user["department_id"], $found_user["hourly_wage"], $found_user["salary"], $found_user["start_date"], 0, $found_user["role"],);

     return $user;
 }

 public static function GetNameById($id)
 {
     $found_user = UserDB::GetNameById($id);

     $name = $found_user["name"];

     return $name;
 }

 public static function GetUsersPassword($email)
 {
    $found_user = UserDB::GetUsersPassword($email);

    $password = $found_user['password'];
 
     return $password;
 }

 //CREATE METHOD
 public function CreateNewUser($firstName, $lastName, $email, $password, $DOB, $phone, $street, $houseNr, $city, $departmentId, $hourlyWage, $salary, $startDate, $endDate, $role)
 {
    UserDB::CreateNewUser($firstName, $lastName, $email, $password, $DOB, $phone, $street, $houseNr, $city, $departmentId, $hourlyWage, $salary, $startDate, $endDate, $role);
 }

 public function UpdateUserInfo($emp_id, $firstName, $lastName, $email, $password, $DOB, $phone, $street, $houseNr, $city, $departmentId, $hourlyWage, $salary, $startDate, $endDate, $role)
 {
    UserDB::UpdateUserInfo($emp_id, $firstName, $lastName, $email, $password, $DOB, $phone, $street, $houseNr, $city, $departmentId, $hourlyWage, $salary, $startDate, $endDate, $role);
    header("location: ../../presentation/profile.php");
 }
}
?>