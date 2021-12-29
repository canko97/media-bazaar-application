<!--Employee nav-->
<?php
include("../includes/Logic/sessionChecker.php");
?>
<nav class="nav_employee">
      <ul class="nav_list_employee">
            <li class="nav_Logo">
                  MediaBazaar
            </li>
            <li class="nav_current_page">
                  <?php echo $currentPage;?>
            </li>
            <li>
                <a href="schedule.php">Schedule</a>
            </li>
            <li>
                  <a class="link" href="../presentation/items.php">Stock</a>
            </li>
            <li>
                <a href="profile.php">Profile</a>
            </li>
            <li>
                  <a href="../includes/Logic/logoutLogic.php"><img src="../images/Exit.png" alt="Exit"></a>
            </li>
      </ul>
</nav>
