create table fees(rno int,name varchar(20),course varchar(20),amount int,paiddate date)
insert into fees values(1,'prachi','dotnet',65,'2023-5-1')
insert into fees values(2,'swayam','java',85,'2023-6-2')
insert into fees values(3,'swara','python',95,'2023-11-3')
insert into fees values(4,'rutuja','full stack',25,'2023-11-2')
insert into fees values(5,'mrunali','web',30,'2023-11-2')
insert into fees values(6,'mina','sql',74,'2023-11-2')
insert into fees values(7,'veena','php',55,'2023-11-2')
insert into fees values(8,'neha','bootstrap',60,'2023-11-1')
insert into fees values(9,'manoj','javascript',45,'2023-3-2')
insert into fees values(2,'madhuri','mvc',15,'2023-2-2')
select * from fees where paiddate between '2023-11-1' and '2023-11-30'
