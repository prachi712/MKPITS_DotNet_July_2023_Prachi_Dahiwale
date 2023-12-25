create table stud_info(rno int,m1 int,m2 int,m3 int)
insert into stud_info values(1,10,11,13)
insert into stud_info values(2,20,22,45)
select * from stud_info

create function fun4 (@m1 int,@m2 int,@m3 int)
returns int
as 
begin
return (select @m1+@m2+@m3) 
end


select dbo.fun4(m1,m2,m3) as 'total mark' from stud_info