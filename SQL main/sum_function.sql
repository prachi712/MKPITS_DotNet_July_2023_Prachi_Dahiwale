create table fstudent(rno int,fdate date,amount int)
insert into fstudent values(1,'2020-2-1',20000)
insert into fstudent values(2,'2021-3-2',50000)
insert into fstudent values(3,'2023-5-2',60000)
select * from fstudent

select sum(amount) as "sum of amount" 
from fstudent
group by rno