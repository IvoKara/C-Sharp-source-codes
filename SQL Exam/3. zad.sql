SELECT employee_id, timediff(check_out, check_in) as work_hours FROM exam.shifts where work_hours > "7:00:00";