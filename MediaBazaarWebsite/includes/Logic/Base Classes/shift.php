<?php
class Shift
{
    private int $shift_id;
    private int $emp_id;
    private string $shift_date;
    private string $timeframe;
    private int $department_id;

    public function __construct(int $shift_id, int $emp_id, string $shift_date, string $timeframe, int $department_id)
    {
        $this->shift_id = $shift_id;
        $this->emp_id = $emp_id;
        $this->shift_date = $shift_date;
        $this->timeframe = $timeframe;
        $this->department_id = $department_id;
    }

    public function GetShiftId(){
        return $this->shift_id;
    }

    public function GetEmpId(){
        return $this->emp_id;
    }

    public function GetShiftDate(){
        return $this->shift_date;
    }

    public function GetTimeframe(){
        return $this->timeframe;
    }

    public function GetDepartment_id(){
        return $this->department_id;
    }

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
        global $database;
        $result_set = $database->query("SELECT * FROM shifts WHERE shift_date = '" . $date . "' AND emp_id =  ".  $id ." " );
        $found_shift = mysqli_fetch_array($result_set);

        return $found_shift;
    }

    public static function PopulateEmployees($date, $department_id){
        $data = Shift::FindShiftsByDate($date, $department_id);
        foreach($data as $shift){
            if($shift != null)
            {
                echo '<li class="shift">' . User::GetNameById($shift['emp_id']) . '</li>';
            }
            else
            {
                echo '<li class="shift">0</li>';
            }
        }
    }


    public static function PopulateMorning($date, $department_id){
        $data = Shift::FindShiftsByDate($date, $department_id);
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
        $data = Shift::FindShiftsByDateAndEmployee($date, $id);
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
        $data = Shift::FindShiftsByDate($date, $department_id);
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
        $data = Shift::FindShiftsByDateAndEmployee($date, $id);
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
        $data = Shift::FindShiftsByDate($date, $department_id);
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
        $data = Shift::FindShiftsByDateAndEmployee($date, $id);
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
