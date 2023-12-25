create table empinfo(name varchar(20) not null,
                     occupation varchar (20) not null,
					 working_hours int,
					 salary int)
insert into empinfo values('prachi','manager',9,900000)
insert into empinfo values('mahima','clerk',5,100000)
insert into empinfo values('swayam','associative',4,800000)
select * from empinfo

select avg(working_hours) as "average working hours"
from empinfo

select avg(salary) as "average salary"
from empinfo