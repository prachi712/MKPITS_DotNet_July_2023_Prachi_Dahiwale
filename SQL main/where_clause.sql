create table studentt(rno int,name varchar(20),city varchar(20))
insert into studentt values(1,'prachi','palandur')
insert into studentt values(2,'swati','bhandara')
insert into studentt values(3,'pratiksha','nagpur')
insert into studentt values(4,'sayyam','chichal')
insert into studentt values(5,'rupa','barwa')
insert into studentt values(6,'bhashkar','pardi')
insert into studentt values(7,'sajuna','salebardi')
select * from studentt where rno=1
select * from studentt where rno>4
select * from studentt where name='sayyam'
select * from studentt where city='pardi'
select * from studentt where name='sayyam' and city='chichal'