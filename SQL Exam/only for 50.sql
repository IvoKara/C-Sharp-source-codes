SELECT Sum(ipo.items_per_order) FROM orders as o 
join 
    (SELECT order_id, sum(quantity) as items_per_order from order_items
	 group by order_id
	 order by order_id) as ipo
		on o.id=ipo.order_id
where employee_id=50;