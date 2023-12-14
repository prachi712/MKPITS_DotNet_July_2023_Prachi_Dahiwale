create table order2(orderdate date,salesmanid int,orderno int,purchamt int)
insert into order2 values('2023-3-3',1,123,500)
insert into order2 values('2023-4-3',2,124,600)
insert into order2 values('2023-5-3',3,125,700)
insert into order2 values('2023-6-3',1,126,800)
insert into order2 values('2023-7-3',1,127,900)
insert into order2 values('2023-8-3',6,128,200)
select * from order2
select distinct salesmanid from order2
drop table order2

