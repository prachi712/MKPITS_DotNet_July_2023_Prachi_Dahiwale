create table stud(rollno int,name varchar(20),city varchar(20))
insert into stud values(1,'prachi','bhandara')
insert into stud values(2,'mrunal','nagpur')
insert into stud values(3,'rita','nagpur')
insert into stud values(4,'pranali','gondia')
insert into stud values(5,'mrunali','nagpur')
select * from stud where city='nagpur' 
order by name
select name,COUNT(*) from stud where city='nagpur' group by name
select name,COUNT(*) from stud where city<>'nagpur' group by name order by name