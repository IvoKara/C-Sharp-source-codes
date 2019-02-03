Select * from 
(
	SELECT e.first_name, e.last_name, avg(timestampdiff(hour, check_in, check_out)) as work_hours 
	FROM shifts as s
	join employees as e
		on s.employee_id=e.id
	group by s.employee_id
	order by work_hours desc
) as sub
where sub.work_hours > 7;