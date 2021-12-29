<?php

include("../init.php");

if (isset($_POST["submit"]))
{
    $monthString = (new mysqli)->real_escape_string($_POST["month"]);
    $temp = (new DateTime)($monthString . '-01');
    $monthName = $temp->format("F Y");

}