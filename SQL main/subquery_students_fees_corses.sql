create table pstudents(rno int,
                       name varchar(20)not null,
					   email varchar(20)not null,
					   city varchar(20)not null,
					   courseid int)
insert into pstudents values(10,'chipra','chipra@gmail.com','nagpur',123)
insert into pstudents values(20,'reshma','reshma@gmail.com','mumbai',456)
insert into pstudents values(30,'sanjana','sanjana@gmail.com','delhi',789)
select * from pstudents

create table pfees(feesid int ,rollno int,amount int,courseid  int)
insert into pfees values(1,10,20000,123)
insert into pfees values(2,20,30000,456)
insert into pfees values(3,30,400000,789)
insert into pfees values(4,40,500000,258)
select * from pfees

drop table pstudents

select feesid,rollno,amount,courseid
from pfees
where courseid in
(select courseid from pstudents 
where city='mumbai')

select feesid,rollno,amount,courseid
from pfees
where courseid in
(select courseid from pstudents where city='delhi')
create table courses(courseid int,coursename varchar(20),fees int)
insert into courses values(123,'java',20000)
insert into courses values(456,'dotnet',30000)
select * from courses
select courseid,coursename,fees
from courses
where courseid in
(select courseid from pstudents
where coursename='java')
