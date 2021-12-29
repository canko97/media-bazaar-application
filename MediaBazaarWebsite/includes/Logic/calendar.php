<?php
class Calendar{
    private $month;
    private $year;
    private $days_of_week;
    private $num_days;
    private $date_info;
    private $day_of_week;

    public function __construct( )
    {   $this->days_of_week = array('S', 'M', 'Tu', 'W', 'Th', 'F', 'S');
        $this->month = date("m");
        $this->year = date("Y");
        $this->num_days = cal_days_in_month(CAL_GREGORIAN, $this->month, $this->year);
        $this->date_info = getdate(strtotime('first day of', mktime(0,0,0, $this->month, 1, $this->year)));
        $this->day_of_week = $this->date_info['wday'];
    }

    public function show()
    {
        // Month and year caption
        $output = '<table class="calendar">';
        $output .= '<tr class="header_row">';

        // Days of the week header
        foreach($this->days_of_week as $day)
        {
            $output .= '<th class = "header"> <h2>' . $day . '</h2></th>';
        }

        // Close header row and open first row of days
        $output .= '</tr><tr>';

        // If first day of the month does not fall on a Sunday, then we need to fill
        // beginning space using colspan
        if( $this->day_of_week > 0 )
        {
            for( $i = 0;$i < $this->day_of_week; $i++ ){
                $output .= '<td class="empty_day"></td>';

            }
        }

        // Start num_days counter
        $current_day = 1;

        //Loop and build days
        while ($current_day <= $this->num_days)
        {
            //Reset 'day of week' counter and close each row if end of row
            if( $this->day_of_week == 7 ){
                $this->day_of_week = 0;
                $output .= '</tr><tr>';
            }

            //Build each day cell
            $output .= '<td onclick="window.location.href=`shifts_per_day.php?date='. "$current_day". '`" class="day">' . $current_day . '</td>';

            // Increment counters
            $current_day++;
            $this->day_of_week++;
        }

        // Once num_days counter stops, if day of week counter is not 7, then we
        // need to fill the remaining space on the row using colspan
//        if ( $this->day_of_week != 7) {
//            $remaining_days = 7 - $this->day_of_week;
//            $output .= '<td class="merged_cells" colspan="' . $remaining_days .'"></td>';
//        }

        // Close final row and table
        $output .= '</tr>';
        $output .= '</table>';

        // Output this sh...
        echo $output;
    }

    public function SetMonth(){
        if (isset($_POST["submit"]))
        {
            $monthString = (new mysqli)->real_escape_string($_POST["month"]);
            $temp = (new DateTime)($monthString . '-01');
            $monthName = $temp->format("F Y");
        }
    }

}