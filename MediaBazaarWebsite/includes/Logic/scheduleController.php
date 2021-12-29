<?php
session_start();
require_once("../init.php");

if(isset($_POST['show_schedule']))
{
    $_SESSION["department_id"] = ($_POST["departments"]);
    header("location: ../../presentation/schedules.php");
}