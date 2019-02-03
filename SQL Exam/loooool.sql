select exp.order_id, exp.expensive_price, ch.cheap_price from 
(select oi.order_id, max(price) as expensive_price from order_items as oi join items as i on oi.item_id=i.id 
group by oi.order_id
order by expensive_price desc, oi.order_id) as exp
join
(select oi.order_id, min(price) as cheap_price from order_items as oi join items as i on oi.item_id=i.id 
group by oi.order_id) as ch
	on exp.order_id=ch.order_id;
    
select *  from order_items as oi join items as i on oi.item_id=i.id ;