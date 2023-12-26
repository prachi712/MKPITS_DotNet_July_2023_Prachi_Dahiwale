create table gethighsal(empname varchar(20)not null,
                        salary int)
insert into gethighsal values('prachi',200)
insert into gethighsal values('mrunal',100)
insert into gethighsal values('pinki',50)
select * from gethighsal

create procedure prod51(@maxsal as decimal)
as begin
select * from gethighsal
where salary>@maxsal
order by salary
end

exec prod51 100

drop procedure prod51