SELECT order_id, sum(quantity) as itmes_per_order from order_items
group by order_id
order by order_id;

select * from order_items;