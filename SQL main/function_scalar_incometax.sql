create table incometax(m1 int,m2 int,m3 int)
insert into incometax values(1,2,3)
insert into incometax values(4,5,6)
insert into incometax values(7,8,9)
select * from incometax


create function calculatetax(@m1 int,@m2 int,@m3 int)
returns int
as begin
return(select @m1+@m2+@m3)
end

select dbo.calculatetax(m1,m2,m3) as 'total tax' from incometax