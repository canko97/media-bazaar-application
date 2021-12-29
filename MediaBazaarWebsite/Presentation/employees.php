<?php
session_start();
include("../includes/init.php");
$currentPage = "Employees"; //Displayed text on the nav changes according to current page
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
    <div class="optionemployees">
        <div class="departmentoption emp_options">
            <label class="content_option" for="department">Department:</label>
            <select class="content_option" name="department" id="department" onchange="DepartementSort()">
                <option value="All Departments">All Departments</option>
                <option value="Administration">Administration</option>
                <option value="HR">HR</option>
                <option value="Marketing">Marketing</option>
                <option value="Logistics">Logistics</option>
            </select>
        </div>
        <div class="roleoption emp_options" >
            <label class="content_option" for="role">Role:</label>
            <select class="content_option" name="role" id="role" onchange="RoleSort()">
                <option value="All Roles">All Roles</option>
                <option value="Admin">Admin</option>
                <option value="Manager">Manager</option>
                <option value="Employee">Employee</option>
            </select>
        </div>
        <div class="searchoption emp_options">
            <input class="content_option" type="text" id="searchbar" onkeyup="searchbar()" placeholder="Search for names..">
        </div>
    </div>

    <div class="bordertable" id="employeetable">
        <table id ="employees"> 
            <tr>
                 <th onclick="sortTable(0)">ID</th>
                 <th onclick="sortTable(1)">Role</th>
                 <th onclick="sortTable(2)">First Name</th>
                 <th onclick="sortTable(3)">Last Name</th>
                 <th onclick="sortTable(4)">Email</th>
                <th onclick="sortTable(5)">Birthday</th>
                <th onclick="sortTable(6)">Phone number</th>
                 <th onclick="sortTable(7)">City</th>
                 <th onclick="sortTable(8)">Department</th>
                 <th onclick="sortTable(9)">Payement</th>
                <th onclick="sortTable(10)">Start Date</th>
                 <th onclick="sortTable(11)">End Date</th>
            </tr>
            <tr>
                 <?php
                     $employees = UserLogic::FindAllUsers();
                    ?>
                    <?php
                    foreach ($employees as $employee){
                 ?>
                 <td> <?php echo $employee['emp_id']; ?> </td>
                 <td> <?php echo $employee['role']; ?> </td>
                <td> <?php echo $employee['first_name']; ?> </td>
                <td> <?php echo $employee['last_name']; ?> </td>
                <td> <?php echo $employee['email']; ?> </td>
                 <td> <?php echo $employee['emp_DOB']; ?> </td>
                <td> <?php echo $employee['phone']; ?> </td>
                <td> <?php echo $employee['city']; ?> </td>
                <td>
                    <?php switch ($employee['department_id'])
                    {
                        case 0:
                            echo "No department";
                            break;
                        case 1:
                            echo "Administration";
                            break;
                        case 2:
                            echo "HR";
                            break;
                        case 3:
                            echo "Logistics";
                             break;
                        case 4:
                            echo "Marketing";
                            break;
                    }
                    ?>
                </td>
                  <td> <?php if ($employee['role'] == "Employee")
                     {
                      echo $employee['hourly_wage'];
                     }
                    else
                     {
                      echo $employee['salary'];
                      }?></td>
                 <td> <?php echo $employee['start_date']; ?> </td>
              <td> <?php echo $employee['end_date']; ?> </td>
              </tr>
	    <?php } ?>
        </table>
     </div>
</body>
<script src="../public/javascript/searchbar.js"></script>
<script src="../public/javascript/tablesort.js"></script>
</html>
