<?php
session_start();
require_once("../includes/init.php");
$day = 0;
if(!isset($_GET['date'])){
    header("schedules.php");
    exit();
}
if(isset($_GET['date'])){
    $day = $_GET['date'];
}
$month = date("m");
$year = date("Y");
$date = $year."-".$month."-".$day;
$currentPage = $date; //Displayed text on the nav changes according to current page
include "../presentation/navbar/navAdmin.php";




?>

<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="../public/css/styles.css">
    <title>Document</title>
</head>

<body>
    <div class="shifts_of_day">
        <div class="shifts_table_heading_container">
            <div class="shifts_table_heading">
                <div class="timeframe">
                    <h3 class="timeframe_title">EMPLOYEES</h3>
                </div>
                <div class="timeframe">
                    <h3 class="timeframe_title">MORNING</h3>
                    <h5 class="timeframe_subtitle">8:00-16:00</h5>
                </div>
                <div class="timeframe">
                    <h3 class="timeframe_title">AFTERNOON</h3>
                    <h5 class="timeframe_subtitle">12:00-20:00</h5>
                </div>
                <div class="timeframe">
                    <h3 class="timeframe_title">EVENING</h3>
                    <h5 class="timeframe_subtitle">16:00-00:00</h5>
                </div>
            </div>
        </div>
        <div class="shift_table_container">
            <div class="shifts_table">
                <div class="timeframe">
                    <ul class="shifts_list">
                        <?php ShiftLogic::PopulateEmployees($date, $_SESSION["department_id"])?>
                    </ul>
                </div>
                <div class="timeframe">
                    <ul class="shifts_list">
                        <?php ShiftLogic::PopulateMorning($date, $_SESSION["department_id"])?>
                    </ul>
                </div>
                <div class="timeframe">
                    <ul class="shifts_list">
                        <?php ShiftLogic::PopulateAfternoon($date, $_SESSION["department_id"])?>
                    </ul>
                </div>
                <div class="timeframe">
                    <ul class="shifts_list">
                        <?php ShiftLogic::PopulateEvening($date, $_SESSION["department_id"])?>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
