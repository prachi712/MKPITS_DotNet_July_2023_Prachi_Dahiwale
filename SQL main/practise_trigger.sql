create table student(studid int primary key,
                     studname varchar(20) not null)
create table studlog(logid int identity(1,1) not null,
                     studid int not null,
					 operation nvarchar(10) not null,
					 updatedate datetime)

create trigger empt
on student
for insert as
insert into
studlog(studid,'operation',updatedate)
select studid,'insert',GATDATE()
from inserted
