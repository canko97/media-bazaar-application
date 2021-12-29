<!--Admin nav-->
<?php
include("../includes/Logic/sessionChecker.php");
?>
<nav class="nav_admin">
      <ul class="nav_list_admin">
            <li class="nav_Logo">
                  MediaBazaar
            </li>
            <li class="nav_current_page">
                  <?php echo $currentPage;?>
            </li>
            <li>
                  <a class="link" href="../presentation/schedules.php">Schedule</a>
            </li>
            <li>
                  <a class="link" href="../presentation/employees.php">Employees</a>
            </li>
            <li>
                  <a class="link" href="../presentation/items.php">Stock</a>
            </li>
            <li>
                  <a class="link" href="../presentation/profile.php">Profile</a>
            </li>
            <li>
                  <a class="link" href="../includes/Logic/logoutLogic.php"><img src="../images/Exit.png" alt="Exit"></a>
            </li>
      </ul>
</nav>