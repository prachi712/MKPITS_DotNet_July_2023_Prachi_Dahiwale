create table product(productid int,
                     productname varchar(20)not null,
					 price int)
insert into product values(1,'mkpits',100)
insert into product values(2,'raisoni',200)
insert into product values(3,'kalode',50)
select * from product
drop table product


create procedure prod6 (@pn as varchar(20) ,@pi as decimal)
as
begin
select * from product
where productname=@pn and price>@pi
order by productname
end

exec prod6 'mkpits' ,100
exec prod6 'raisoni', 50



