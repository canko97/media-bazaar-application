<?php
class UnavailabilityDB
{
    public function GetUnavailabilty($emp_id)
    {
        global $database;
        $result_set = $database->query("SELECT * FROM shift_preferences WHERE emp_id = '$emp_id'");
        $found_days = mysqli_fetch_array($result_set);

        return $found_days;
    }
    public function UpdateUnavailability($emp_id, $new_days)
    {
        global $database;
   
        $sql = "Update shift_preferences Set ";  
        $sql .= "monday = '" . $database->escape_string($new_days[0]) . "', ";
        $sql .= "tuesday = '" . $database->escape_string($new_days[1]) . "', ";
        $sql .= "wednesday = '" . $database->escape_string($new_days[2]) . "', ";
        $sql .= "thursday = '" . $database->escape_string($new_days[3]) . "', ";
        $sql .= "friday = '" . $database->escape_string($new_days[4]) . "', ";
        $sql .= "saturday = '" . $database->escape_string($new_days[5]) . "', ";
        $sql .= "sunday = '" . $database->escape_string($new_days[6]) . "' ";
        $sql .= "WHERE emp_id = " . $emp_id . "";

        $database->query($sql);
    }
    public function AddUnavailability($emp_id, $new_days)
    {
        global $database;
        
        $sql = "Insert Into shift_preferences (emp_id,monday,tuesday,wednesday,thursday,friday,saturday,sunday)";
        $sql .= "VALUES ('";
        $sql .= $database->escape_string($emp_id) . "', '";
        $sql .= $database->escape_string($new_days[0]) . "', '";
        $sql .= $database->escape_string($new_days[1]) . "', '";
        $sql .= $database->escape_string($new_days[2]) . "', '";
        $sql .= $database->escape_string($new_days[3]) . "', '";
        $sql .= $database->escape_string($new_days[4]) . "', '";
        $sql .= $database->escape_string($new_days[5]) . "', '";
        $sql .= $database->escape_string($new_days[6]) . "')";

        $database->query($sql);
    }
}
?>