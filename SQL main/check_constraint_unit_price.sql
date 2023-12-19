create table product1(product_id int primary key,
                      product_name varchar(20) not null,
					  unit_price DEC(10,2)check(unit_price>0))
insert into product1(product_id,product_name,unit_price)values(1,'prachi',120)
insert into product1(product_id,product_name,unit_price)values(2,'sayali',201)
insert into product1(product_id,product_name,unit_price)values(3,'swayam',582)
select * from product1
drop table product1
insert into product1(product_id,product_name,unit_price)values(4,'chipra',0)