create table orders(productid int,custname varchar(20),productname varchar(20),quantity int,orderdate date)
insert into orders values(1,'prachi','computer',1,'2022-9-7')
insert into orders values(2 ,'swayam','laptop',3,'2020-7-9')
insert into orders values(2 ,'swa','top',3,'2020-7-9')
insert into orders values(2 ,'swayam','laptop',3,'2020-7-9')
insert into orders values(2 ,'swayam','laptop',3,'2020-7-9')
insert into orders values(2 ,'wayam','laptop',3,'2020-7-9')
insert into orders values(2 ,'swyam','laptop',3,'2020-7-9')
insert into orders values(2 ,'swam','laptop',3,'2020-7-9')
select * from orders where orderdate between '2020-7-9' and '2020-9-7'