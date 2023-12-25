create function fun_emp1
(

@empcontact varchar(20),
@empname varchar (20),
@empcity varchar(20)
)
returns varchar(20)
as begin return (select @empcontact+ ' '+@empname+ ' ' +@empcity)
end

select dbo.fun_emp1(empcontact,empname,empcity) from employees
select * from employees