create table scustomers(custid int,
                        custname varchar(20) not null,
						state varchar(20) not null,
						city varchar(20))

insert into scustomers values(1,'prachi','maharashtra','nagpur')
insert into scustomers values(2,'naina','bhopal','jabalpur')
insert into scustomers values(3,'kanta','odisa','bhilai')
select * from scustomers

create table sorders(orderid int ,custid int,productname varchar(20)not null)
insert into sorders values(1,1,'mouse')
insert into sorders values(2,2,'keyboard')
insert into sorders values(3,3,'laptop')
insert into sorders values(4,4,'computer')
select * from sorders
drop table sorders
select custid from scustomers 
where city='nagpur'
select orderid,custid,productname
from sorders 
where custid in
(select custid from scustomers where city='nagpur')
select orderid,custid,productname 
from sorders
where custid in 
(select custid from scustomers where city='jabalpur')
order by orderid desc