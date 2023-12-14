create table customerss1(first_name varchar(20),custid int,last_name varchar(20))
insert into customerss1 values('prachi',1,'dahiwale')
insert into customerss1 values('mrunal',2,'gajbhiye')
insert into customerss1 values('meunali',3,'kolte')
insert into customerss1 values('rita',4,'ingole')
insert into customerss1 values('ritudi',5,'inga')
select first_name,last_name from customerss1 order by LEN(first_name)
select * from customerss1