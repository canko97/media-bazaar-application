<?php
include_once("../includes/data/UserDB.php");
require_once("Base Classes/item.php");
class ItemLogic
{
    public static function FindAllItems()
    {
     $result_set = ItemDB::FindAllItems();
     return $result_set; 
    }
}
?>