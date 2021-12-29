<?php
class ShiftDB
{
    public static function FindAllShifts()
    {
        global $database;
        $result_set = $database->query("SELECT * FROM shifts");
        return $result_set;
    }
    public static function FindShiftsByDate($date, $department_id)
    {
        global $database;
        $result_set = $database->query("SELECT * FROM shifts WHERE shift_date = '" . $date . "' AND department_id = '" . $department_id . "'");
        
        return $result_set;
    }
    public static function FindShiftsByDateAndEmployee($date, $id)
    {
        global $database;
        $result_set = $database->query("SELECT * FROM shifts WHERE shift_date = '" . $date . "' AND emp_id =  ".  $id ." " );
        $found_shift = mysqli_fetch_array($result_set);

        return $found_shift;
    }

}
?>