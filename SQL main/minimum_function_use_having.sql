create table fproduct(productname varchar(20)not null,
                      quantity int not null,
					  price int not null)
insert into fproduct values('computer',10,100)
insert into fproduct values('laptop',20,200)
insert into fproduct values('mouse',30,300)
insert into fproduct values('iphone',40,400)
insert into fproduct values('smartphone',50,500)
select * from fproduct


select productname,
min(price)as "minimum price"
from fproduct
group by productname
having min(price)>300
drop table fproduct
