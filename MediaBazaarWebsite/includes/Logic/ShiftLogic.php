<?php
include_once("../includes/data/ShiftDB.php");
require_once("Base Classes/shift.php");
class ShiftLogic
{
    public static function FindAllShifts()
    {
        $result_set = ShiftDB::FindAllShifts();
        return $result_set;
    }

    public static function FindShiftsByDate($date, $department_id)
    {    
        $result_set = ShiftDB::FindShiftsByDate($date, $department_id);
        $data = array();
        if(mysqli_num_rows($result_set) > 0){
            while($row = mysqli_fetch_assoc($result_set)){
                $data[] = $row;
            }
        }
        return $data;
    }
    public static function FindShiftsByDateAndEmployee($date, $id)
    {
        $found_shift = ShiftDB::FindShiftsByDateAndEmployee($date, $id);

        return $found_shift;
    }

    public static function PopulateEmployees($date, $department_id){
        $data = ShiftDB::FindShiftsByDate($date, $department_id);
        foreach($data as $shift){
            if($shift != null)
            {
                echo '<li class="shift">' . UserLogic::GetNameById($shift['emp_id']) . '</li>';
            }
            else
            {
                echo '<li class="shift">0</li>';
            }
        }
    }


    public static function PopulateMorning($date, $department_id){
        $data = ShiftDB::FindShiftsByDate($date, $department_id);
        foreach($data as $shift){
            if($shift['timeframe'] == "MORNING" || $shift['timeframe'] == "MORNING-AFTERNOON" || $shift['timeframe'] == "MORNING-EVENING")
            {
                echo '<li class="full-shift"></li>';
            }
            else
            {
                echo '<li class="empty-shift"></li>';
            }
        }
    }

    public static function PopulateMorningPerDay($date, $id){
        $data = ShiftDB::FindShiftsByDateAndEmployee($date, $id);
        if($data){
            if($data['timeframe'] == "MORNING" || $data['timeframe'] == "MORNING-AFTERNOON" || $data['timeframe'] == "MORNING-EVENING")
            {
                echo '<li class="full-shift"></li>';
            }
            else
            {
                echo '<li class="empty-shift"></li>';
            }
        }
        else{
            echo '<li class="empty-shift"></li>';
        }

    }

    public static function PopulateAfternoon($date, $department_id){
        $data = ShiftDB::FindShiftsByDate($date, $department_id);
        foreach($data as $shift){
            if($shift['timeframe'] == "AFTERNOON" || $shift['timeframe'] == "MORNING-AFTERNOON" || $shift['timeframe'] == "AFTERNOON-EVENING" || $shift['timeframe'] == "MORNING-EVENING")
            {
                echo '<li class="full-shift"></li>';
            }
            else
            {
                echo '<li class="empty-shift"></li>';
            }
        }
    }

    public static function PopulateAfternoonPerDay($date, $id){
        $data = ShiftDB::FindShiftsByDateAndEmployee($date, $id);
        if($data){
            if($data['timeframe'] == "AFTERNOON" || $data['timeframe'] == "MORNING-AFTERNOON" || $data['timeframe'] == "AFTERNOON-EVENING" || $data['timeframe'] == "MORNING-EVENING")
            {
                echo '<li class="full-shift"></li>';
            }
            else
            {
                echo '<li class="empty-shift"></li>';
            }
        }
        else{
            echo '<li class="empty-shift"></li>';
        }

    }

    public static function PopulateEvening($date, $department_id){
        $data = ShiftDB::FindShiftsByDate($date, $department_id);
        foreach($data as $shift){
            if($shift['timeframe'] == "EVENING" || $shift['timeframe'] == "AFTERNOON-EVENING" || $shift['timeframe'] == "MORNING-EVENING")
            {
                echo '<li class="full-shift"></li>';
            }
            else
            {
                echo '<li class="empty-shift"></li>';
            }
        }
    }

    public static function PopulateEveningPerDay($date, $id){
        $data = ShiftDB::FindShiftsByDateAndEmployee($date, $id);
        if($data){
            if($data['timeframe'] == "EVENING" || $data['timeframe'] == "AFTERNOON-EVENING" || $data['timeframe'] == "MORNING-EVENING")
            {
                echo '<li class="full-shift"></li>';
            }
            else
            {
                echo '<li class="empty-shift"></li>';
            }
        }
        else{
            echo '<li class="empty-shift"></li>';
        }

    }
}
?>