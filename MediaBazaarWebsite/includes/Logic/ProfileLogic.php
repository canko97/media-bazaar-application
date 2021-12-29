<?php
require_once("../init.php");
session_start();
$logged_in_user = UserLogic::GetUserById($_SESSION['id']);

if(isset ($_POST['edit_info']))
{
    $email = $_POST['email'];
    $phone = $_POST['phone'];
    $city = $_POST['city'];
    $street = $_POST['street'];
    $house_nr = $_POST['house_number'];

    UserLogic::UpdateUserInfo($logged_in_user->GetId(), $logged_in_user->GetFirstName(), $logged_in_user->GetLastName(), $email, $logged_in_user->GetPassword(), $logged_in_user->GetDOB(), $phone, $street, $house_nr, $city, $logged_in_user->GetDepartmentId(), $logged_in_user->GetHourlyWage(), $logged_in_user->GetSalary(), $logged_in_user->GetStarDate(), "NULL", $logged_in_user->GetRole());
}
else if(isset ($_POST['change_unavailability']))
{
    $days = [
     0 => $_POST['Monday'],
     1 => $_POST['Tuesday'],
     2 => $_POST['Wednesday'],
     3 => $_POST['Thursday'],
     4 => $_POST['Friday'],
     5 => $_POST['Saturday'],
     6 => $_POST['Sunday']
    ];

    UnavailabilityLogic::CheckUnavailability($logged_in_user->GetId(),$days);
}
?>