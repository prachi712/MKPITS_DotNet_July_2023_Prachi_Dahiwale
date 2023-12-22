create table product(productid int,
                     productname varchar(20)not null,
					 price int)
insert into product values(1,'mkpits',100)
insert into product values(2,'raisoni',200)
insert into product values(3,'kalode',50)
select * from product
drop table product


create procedure prod4(@minprise as decimal)
as
begin
select * from product
where price>@minprise
order by price
end

exec prod4 100
exec prod4 50
exec prod4 200