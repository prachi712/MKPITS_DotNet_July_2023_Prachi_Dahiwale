create table getemployeebydepartment(empname varchar(20)not null,
                                      department_id int not null)
									  drop table getemployeebydepartment
insert into getemployeebydepartment values('prachi',1)
insert into getemployeebydepartment values('mrunal',1)
insert into getemployeebydepartment values('kareena',1)

create procedure prod0(@id as decimal)
as begin 
select * from getemployeebydepartment
where department_id=@id
end


exec prod0 1

