<?php
session_start();
include("../includes/init.php");
$currentPage = "Stock"; //Displayed text on the nav changes according to current page
$role = $_SESSION['role'];
if($role == "Admin")
{
    include "navbar/navAdmin.php";
}
else if($role == "Employee")
{
    include "navbar/navEmployee.php";
}
else
{
    header("location: ../presentation/login.php");
}
?>

<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="../public/css/styles.css">
    <title>Document</title>
</head>

<body>
    <div class="optionitems">
        <div class="category optionitem">
            <label class="options" for="category">Category:</label>
            <select class="options" name="category" id="category" onchange="CategorySort()">
                <option value="ALL">ALL</option>
                <option value="KEYBOARDS">KEYBOARDS</option>
                <option value="HEADPHONES">HEADPHONES</option>
                <option value="MOUSES">MOUSES</option>
            </select>
        </div>
        <div class="searchbar optionitem">
        <input class="options" type="text" id="searchbaritem" onkeyup="searchbaritem()" placeholder="Search for names..">
        </div>
    </div>
    <div class="bordertable" id="itemtable">
        <table id ="items"> 
	        <tr>
	         <th onclick="sortTable(0)">ID</th>
             <th onclick="sortTable(1)">Name</th>
	         <th onclick="sortTable(2)">Price</th>
             <th onclick="sortTable(3)">Category</th>
	         <th onclick="sortTable(4)">In store Amount</th>
	        <th onclick="sortTable(5)">Warehouse Amount</th>
            <th onclick="sortTable(6)">Minimum Amount</th>
            <th onclick="sortTable(6)">Maximum Amount</th>
	        </tr>
          <tr>
             <?php 
                 $items = ItemLogic::FindAllItems();
                ?>
            <?php
                foreach ($items as $item){ 
             ?>
	         <td> <?php echo  $item['item_id']; ?> </td>
             <td> <?php echo  $item['item_name']; ?> </td>
            <td> <?php echo  $item['price']; ?>€ </td>
            <td> <?php echo  $item['category']; ?> </td>
            <td> <?php echo  $item['in_store_amount']; ?> </td>
             <td> <?php echo  $item['warehouse_amount']; ?> </td>
             <td> <?php echo $item['min_quantity']; ?> </td>
             <td> <?php echo $item['max_quantity']; ?> </td>
          </tr>
	    <?php } ?>
        </table>
     </div>
</body>
<script src="../public/javascript/searchbar.js"></script>
<script src="../public/javascript/tablesort.js"></script>
</html>
