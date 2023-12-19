create table product2(product_id int primary key,
                      product_name varchar(20)not null,
					  unit_price DEC (10,2) constraint positive_price check(unit_price>0))
					  insert into product2(product_id,product_name,unit_price)values(1,'sneha',204)
					  drop table product2
					  select * from product2