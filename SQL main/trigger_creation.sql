create table temployee(empid int primary key,
                       empname varchar(20))

create table emplog(logid int identity(1,1)not null,
                    empid int not null,
					operation nvarchar(10)not null,
					updateddate datetime not null)

create trigger empt
on temployee
for insert as
insert into
emplog(empid,operation,updateddate)
select empid ,'insert',GETDATE() from inserted


insert into temployee values(1,'prachi')
insert into temployee values(2,'swara')
insert into temployee values(3,'parvati')
select * from temployee
select * from emplog
