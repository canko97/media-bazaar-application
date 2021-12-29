<?php
if($_SESSION['id'] == NULL)
{
    header("location: ../presentation/login.php");
}
?>