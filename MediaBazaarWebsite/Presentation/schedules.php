<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="../public/css/styles.css">
    <title>Document</title>
</head>

<body>
<?php
session_start();
$currentPage = "Schedule"; //Displayed text on the nav changes according to current page
$month = date("F");
$year = date("Y");
$monthName = date("F Y");
$department_id = $_SESSION["department_id"];
include ("../includes/logic/calendar.php");
include("../includes/init.php");
include "../presentation/navbar/navAdmin.php";
if (isset($_POST["submit"]))
{
    $monthString = (new mysqli)->real_escape_string($_POST["month"]);
    try {
        $temp = new DateTime($monthString . '-01');
    } catch (Exception $e) {
    }
    $monthName = $temp->format("F Y");
}

?>
<div class="schedule">
    <div class="side_div_up"></div>
    <div class="side_div"></div>
    <form  class="calendar_control" action="../includes/Logic/scheduleController.php" method="POST">
        <div class="control choose_department">
            <h3>Choose department</h3>
            <select class="selection" name="departments" id="departments" >
                <?php DepartmentLogic::EchoAllDepartments($department_id); ?>
            </select>
        </div>

        <div class=" control calendar_caption">
            <h1 class="h1_calendar_caption"><?php echo $monthName;?> </h1>
        </div>
<!--        <div class="control choose_month" >-->
<!--            <h3>Choose month</h3>-->
<!--            <input class="selection" type="month" name="month" value="">-->
<!--        </div>-->

        <div class="control button">
            <input class = show_schedule_button type="submit" name="show_schedule" value="Refresh Schedule">
        </div>
    </form>
    <?php
    $calendar = new Calendar ();
    $calendar->show();
    ?>
    <div class="side_div"></div>
    <div class="side_div_up"></div>
</div>

</body>
<script src="../public/javascript/javascript.js"></script>
</html>