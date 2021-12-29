<?php
include_once("../includes/data/UnavailabilityDB.php");
class UnavailabilityLogic
{
    public function GetUnavailabilty($emp_id)
    {
       $olddays = UnavailabilityDB::GetUnavailabilty($emp_id);
       return $olddays;
    }   
    
    public function CheckUnavailability($emp_id, $days)
    {
       $olddays = UnavailabilityLogic::GetUnavailabilty($emp_id);
       if($olddays == NULL)
       {
        UnavailabilityDB::AddUnavailability($emp_id,$days);
        header("location: ../../presentation/profile.php");
       }
       else
       {
        UnavailabilityDB::UpdateUnavailability($emp_id, $days);
        header("location: ../../presentation/profile.php");
       }
    }  
}
?>