create table orders11(orderid int primary key,orderdate date,custid int)
create table orderdetails(orderid int primary key,product_name varchar(20),quantity int,
                              constraint fk11 foreign key (orderid)
							  references orders11(orderid))
insert into orders values(1,'2020-2-3',132)
select * from orders
insert into orderdetails values(1,'computer',11)
insert into orderdetails values(2,'keyboard',3)
insert into orderdetails values(3,'mouse',2)
select *  from orderdetails
drop table orderdetails
create table orderdetails(orderid int primary key,product_name varchar(20),quantity int,
                              constraint fk1 foreign key (orderid)
							  references orders11(orderid))
							  insert into orderdetails values(1,'computer',11)

insert into orders11 values(1,'2020-2-3',123)
select * from orders11
insert into orders11 values(2,'2020-2-6',235)
insert into orders11 values(3,'2020-2-6',235)
insert into orders11 values(4,'2020-2-6',235)
select * from orders11
delete from orders11 where orderid=3
select * from orders11