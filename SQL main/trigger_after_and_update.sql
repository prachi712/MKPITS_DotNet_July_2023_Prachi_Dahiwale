create table employee(first_name varchar(20)not null,
                      last_name varchar(20)not null,
					  email varchar(20)not null,
					  phone int not null,
					  hiredate date,
					  managerid int not null,
					  salary int not null,
					  empid int not null)
create table emplog1(logid int identity(1,1)not null,
                     empid int not null,
					 operation nvarchar(10)not null,
					 updateddate date)
                     
create trigger empt2
on employee
after update as
insert into
emplog1(empid,operation,updateddate)
select empid,'update',GETDATE() from deleted

drop table emplog1
drop table employee

insert into employee values('prachi','dahiwale','prachi@gmail.com',77745123,'2020-2-1',123,30000,1)
insert into employee values('mrunal','gajbhiye','mrunal@gmail.com',745896,'2021-3-4',456,10000,2)

update employee set first_name='prachi' where managerid=123
select * from employee
select * from emplog1
drop trigger empt2