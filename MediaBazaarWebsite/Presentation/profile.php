
<?php 
    include("../includes/init.php");
    session_start(); 
    include("../includes/Logic/sessionChecker.php");
    $logged_in_user = UserLogic::GetUserById($_SESSION['id']); 
    $olddays = UnavailabilityDB::GetUnavailabilty($_SESSION['id']);

    $currentPage = "Profile"; //Displayed text on the nav changes according to current page
    $role = $_SESSION['role'];
    if($role == "Admin")
    {
        include "navbar/navAdmin.php";
    }
    else if($role == "Employee")
    {
        include "navbar/navEmployee.php";
    }

    ?>

<html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link rel="stylesheet" href="../public/css/styles.css">
        <title>Document</title>
    </head>

    <body class="profile_body">
        <main class="profile_content">
            <div class="profile_information card">
                <ul class="profile_information_ul">
                    <li><h3> ID: <?php echo $logged_in_user->GetId()?></h3></li>
                    <li><h3> First Name: <?php echo $logged_in_user->GetFirstName()?></h3></li>
                    <li><h3> Last Name: <?php echo $logged_in_user->GetLastName()?></h3></li>
                    <li><h3> Date of birth: <?php echo $logged_in_user->GetDOB()?></h3></li>
                    <li><h3> Department ID: <?php echo $logged_in_user->GetDepartmentId()?></h3></li>
                    <li><h3> Date of employment: <?php echo $logged_in_user->GetStarDate()?></h3></li>
                    <li><h3> Role: <?php echo $logged_in_user->GetRole()?></h3></li>
                </ul>
            </div>
            <?php
            if($role == "Employee")
            {
            ?>
            <form class="preferences_form card" action="../includes/logic/ProfileLogic.php" method="POST" >
                <div class="preferences_form_div">
                    <div class="text_header">
                        <h1>Input Unavailability</h1>
                    </div>
                    <ul class="input-list-combo">
                        <label for="house" class="profile_label">Monday: </label>
                        <select name="Monday">
                            <option value="NONE"<?php if($olddays == null || $olddays[1] == 'NONE')echo ' selected=""'; ?>>None</option>
                            <option value="MORNING"<?php if($olddays[1] == 'MORNING')echo ' selected=""'; ?>>Morning</option>
                            <option value="AFTERNOON"<?php if($olddays[1] == 'AFTERNOON')echo ' selected=""'; ?>>Afternoon</option>
                            <option value="EVENING"<?php if($olddays[1] == 'EVENING')echo ' selected=""'; ?>>Evening</option>
                            <option value="ALL"<?php if($olddays[1] == 'ALL')echo 'selected="selected"'; ?>>All</option>
                        </select>
                        <li class="input_button"></li>
                        <label for="house" class="profile_label">Tuesday: </label>
                         <select name="Tuesday">
                         <option value="NONE"<?php if($olddays == null || $olddays[2] == 'NONE')echo ' selected=""'; ?>>None</option>
                            <option value="MORNING"<?php if($olddays[2] == 'MORNING')echo ' selected=""'; ?>>Morning</option>
                            <option value="AFTERNOON"<?php if($olddays[2] == 'AFTERNOON')echo ' selected=""'; ?>>Afternoon</option>
                            <option value="EVENING"<?php if($olddays[2] == 'EVENING')echo ' selected=""'; ?>>Evening</option>
                            <option value="ALL"<?php if($olddays[2] == 'ALL')echo 'selected="selected"'; ?>>All</option>
                        </select>
                        <li class="input_button"></li>
                        <label for="house" class="profile_label">Wednesday: </label>
                         <select name="Wednesday">
                         <option value="NONE"<?php if($olddays == null || $olddays[3] == 'NONE')echo ' selected=""'; ?>>None</option>
                            <option value="MORNING"<?php if($olddays[3] == 'MORNING')echo ' selected=""'; ?>>Morning</option>
                            <option value="AFTERNOON"<?php if($olddays[3] == 'AFTERNOON')echo ' selected=""'; ?>>Afternoon</option>
                            <option value="EVENING"<?php if($olddays[3] == 'EVENING')echo ' selected=""'; ?>>Evening</option>
                            <option value="ALL"<?php if($olddays[3] == 'ALL')echo 'selected="selected"'; ?>>All</option>
                        </select>
                        <li class="input_button"></li><label for="house" class="profile_label">Thursday: </label>
                         <select name="Thursday">
                         <option value="NONE"<?php if($olddays == null || $olddays[4] == 'NONE')echo ' selected=""'; ?>>None</option>
                            <option value="MORNING"<?php if($olddays[4] == 'MORNING')echo ' selected=""'; ?>>Morning</option>
                            <option value="AFTERNOON"<?php if($olddays[4] == 'AFTERNOON')echo ' selected=""'; ?>>Afternoon</option>
                            <option value="EVENING"<?php if($olddays[4] == 'EVENING')echo ' selected=""'; ?>>Evening</option>
                            <option value="ALL"<?php if($olddays[4] == 'ALL')echo 'selected="selected"'; ?>>All</option>
                        </select>
                        <li class="input_button"></li><label for="house" class="profile_label">Friday: </label>
                         <select name="Friday">
                         <option value="NONE"<?php if($olddays == null || $olddays[5] == 'NONE')echo ' selected=""'; ?>>None</option>
                            <option value="MORNING"<?php if($olddays[5] == 'MORNING')echo ' selected=""'; ?>>Morning</option>
                            <option value="AFTERNOON"<?php if($olddays[5] == 'AFTERNOON')echo ' selected=""'; ?>>Afternoon</option>
                            <option value="EVENING"<?php if($olddays[5] == 'EVENING')echo ' selected=""'; ?>>Evening</option>
                            <option value="ALL"<?php if($olddays[5] == 'ALL')echo 'selected="selected"'; ?>>All</option>
                        </select>
                        <li class="input_button"></li><label for="house" class="profile_label">Saturday: </label>
                         <select name="Saturday">
                         <option value="NONE"<?php if($olddays == null || $olddays[6] == 'NONE')echo ' selected=""'; ?>>None</option>
                            <option value="MORNING"<?php if($olddays[6] == 'MORNING')echo ' selected=""'; ?>>Morning</option>
                            <option value="AFTERNOON"<?php if($olddays[6] == 'AFTERNOON')echo ' selected=""'; ?>>Afternoon</option>
                            <option value="EVENING"<?php if($olddays[6] == 'EVENING')echo ' selected=""'; ?>>Evening</option>
                            <option value="ALL"<?php if($olddays[6] == 'ALL')echo 'selected="selected"'; ?>>All</option>
                        </select>
                        <li class="input_button"></li><label for="house" class="profile_label">Sunday: </label>
                         <select name="Sunday">
                         <option value="NONE"<?php if($olddays == null || $olddays[7] == 'NONE')echo ' selected=""'; ?>>None</option>
                            <option value="MORNING"<?php if($olddays[7] == 'MORNING')echo ' selected=""'; ?>>Morning</option>
                            <option value="AFTERNOON"<?php if($olddays[7] == 'AFTERNOON')echo ' selected=""'; ?>>Afternoon</option>
                            <option value="EVENING"<?php if($olddays[7] == 'EVENING')echo ' selected=""'; ?>>Evening</option>
                            <option value="ALL"<?php if($olddays[7] == 'ALL')echo 'selected="selected"'; ?>>All</option>
                        </select>
                        <li class="input_button"><input class="input-button" type="submit" name="change_unavailability" value="Change Unavailability"></li>
                    </ul>
                </div>
                <?php
                }
                ?>
            </form>

            <form class="profile_form card" action="../includes/logic/ProfileLogic.php" method="POST" >
                <div class="profile_form_div">
                    <div class="text_header">
                        <h1>Edit Personal Info</h1>
                    </div>
                    <ul class="input-list">
                        <li class="input" id="mail"><label for="house" class="profile_label">Email: </label> <input class="input-item" type="email" name="email" value="<?php echo $logged_in_user->GetEmail()?>" placeholder="Email"></li>
                        <li class="input" id="phone"><label for="house" class="profile_label">Phone Number: </label> <input class="input-item" type="tel" name="phone" value="<?php echo $logged_in_user->GetPhone()?>" placeholder="Phone"></li>
                        <li class="input" id="city"><label for="house" class="profile_label">City: </label> <input class="input-item" type="text" name="city" value="<?php echo $logged_in_user->GetCity()?>" placeholder="City"></li>
                        <li class="input" id="street"><label for="house" class="profile_label">Street: </label><input class="input-item" type="text" name="street" value="<?php echo $logged_in_user->GetStreet()?>" placeholder="Street"></li>
                        <li class="input" id="house"><label for="house" class="profile_label">House Number: </label><input class="input-item" type="number" name="house_number" value="<?php echo $logged_in_user->GetHouseNr()?>" placeholder="House Number"></li>
                        <li class="input_button"><input class="input-button" type="submit" name="edit_info" value="Edit Information"></li>
                    </ul>
                </div>
            </form>
        </main>
    </body>
</html>


