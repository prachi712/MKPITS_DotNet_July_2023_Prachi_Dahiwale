create table getemployeecount(empname varchar(20) not null)
insert into getemployeecount values('prachi')
insert into getemployeecount values('mayuri')
insert into getemployeecount values('vrushali')
insert into getemployeecount values('akansha')
insert into getemployeecount values('pradnya')
select * from  getemployeecount

create procedure prod11
as begin 
select * from getemployeecount

end

exec prod11

select count(empname) as 'total employee' from getemployeecount
drop procedure prod11