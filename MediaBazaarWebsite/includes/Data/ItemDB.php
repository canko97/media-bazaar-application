<?php
class ItemDB
{
    public static function FindAllItems()
    {
     global $database;
     $result_set = $database->query("SELECT * FROM items");
     return $result_set; 
    }
}
?>