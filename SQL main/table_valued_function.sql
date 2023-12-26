create table ffemployee(empid int,empname varchar(20),departmentid int)
insert into ffemployee values(1,'prachi',12)
insert into ffemployee values(2,'sara',12)
insert into ffemployee values(3,'leela',78)
select * from ffemployee
create function show(
@department_id int)
returns int
as begin
return(select +@department_id+ ' ')
end

select dbo.show(departmentid)from ffemployee

drop function show