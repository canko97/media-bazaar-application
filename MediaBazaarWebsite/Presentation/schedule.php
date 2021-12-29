<!--Employee schedule page(Schedule)-->
<?php
session_start();
$currentPage = "Schedule"; //Displayed text on the nav changes according to current page
include("../includes/init.php");
include ("navbar/navEmployee.php");
$logged_in_user = UserLogic::GetUserById($_SESSION['id']);
$date = new DateTime('now')
?>
<!DOCTYPE html>
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
                    <h3 class="timeframe_title">DATES</h3>
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
                        <li class="shift"><?php echo $date->format("l, d F Y") ?></li>
                        <li class="shift"><?php $date->modify("+1 day");
                                            echo $date->format("l, d F Y") ?></li>
                        <li class="shift"><?php $date->modify("+1 day");
                                                echo $date->format("l, d F Y") ?></li>
                        <li class="shift"><?php $date->modify("+1 day");
                                                echo $date->format("l, d F Y") ?></li>
                        <li class="shift"><?php $date->modify("+1 day");
                                                echo $date->format("l, d F Y") ?></li>
                        <li class="shift"><?php $date->modify("+1 day");
                                                echo $date->format("l, d F Y"); ?></li>
                        <li class="shift"><?php $date->modify("+1 day");
                                                echo $date->format("l, d F Y");
                                                $date->modify("-6 day"); ?></li>
                    </ul>
                </div>
                <div class="timeframe">
                    <ul class="shifts_list">
                        <?php
                        Shift::PopulateMorningPerDay($date->format("Y-m-d"), $_SESSION['id']);
                        $date->modify("+1 day");
                        Shift::PopulateMorningPerDay($date->format("Y-m-d"), $_SESSION['id']);
                        $date->modify("+1 day");
                        Shift::PopulateMorningPerDay($date->format("Y-m-d"), $_SESSION['id']);
                        $date->modify("+1 day");
                        Shift::PopulateMorningPerDay($date->format("Y-m-d"), $_SESSION['id']);
                        $date->modify("+1 day");
                        Shift::PopulateMorningPerDay($date->format("Y-m-d"), $_SESSION['id']);
                        $date->modify("+1 day");
                        Shift::PopulateMorningPerDay($date->format("Y-m-d"), $_SESSION['id']);
                        $date->modify("+1 day");
                        Shift::PopulateMorningPerDay($date->format("Y-m-d"), $_SESSION['id']);
                        $date->modify("-6 day");
                        ?>
                    </ul>
                </div>
                <div class="timeframe">
                    <ul class="shifts_list">
                        <?php
                        Shift::PopulateAfternoonPerDay($date->format("Y-m-d"), $_SESSION['id']);
                        $date->modify("+1 day");
                        Shift::PopulateAfternoonPerDay($date->format("Y-m-d"), $_SESSION['id']);
                        $date->modify("+1 day");
                        Shift::PopulateAfternoonPerDay($date->format("Y-m-d"), $_SESSION['id']);
                        $date->modify("+1 day");
                        Shift::PopulateAfternoonPerDay($date->format("Y-m-d"), $_SESSION['id']);
                        $date->modify("+1 day");
                        Shift::PopulateAfternoonPerDay($date->format("Y-m-d"), $_SESSION['id']);
                        $date->modify("+1 day");
                        Shift::PopulateAfternoonPerDay($date->format("Y-m-d"), $_SESSION['id']);
                        $date->modify("+1 day");
                        Shift::PopulateAfternoonPerDay($date->format("Y-m-d"), $_SESSION['id']);
                        $date->modify("-6 day");
                        ?>
                    </ul>
                </div>
                <div class="timeframe">
                    <ul class="shifts_list">
                        <?php
                        Shift::PopulateEveningPerDay($date->format("Y-m-d"), $_SESSION['id']);
                        $date->modify("+1 day");
                        Shift::PopulateEveningPerDay($date->format("Y-m-d"), $_SESSION['id']);
                        $date->modify("+1 day");
                        Shift::PopulateEveningPerDay($date->format("Y-m-d"), $_SESSION['id']);
                        $date->modify("+1 day");
                        Shift::PopulateEveningPerDay($date->format("Y-m-d"), $_SESSION['id']);
                        $date->modify("+1 day");
                        Shift::PopulateEveningPerDay($date->format("Y-m-d"), $_SESSION['id']);
                        $date->modify("+1 day");
                        Shift::PopulateEveningPerDay($date->format("Y-m-d"), $_SESSION['id']);
                        $date->modify("+1 day");
                        Shift::PopulateEveningPerDay($date->format("Y-m-d"), $_SESSION['id']);
                        $date->modify("-6 day");
                        ?>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</body>
</html>