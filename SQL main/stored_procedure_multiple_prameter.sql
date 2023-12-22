create table product(productid int,
                     productname varchar(20)not null,
					 price int)
insert into product values(1,'mkpits',100)
insert into product values(2,'raisoni',200)
insert into product values(3,'kalode',50)
select * from product
drop table product


create procedure prod9 (@minprice as decimal ,@maxprice as decimal)
as
begin
select * from product
where price>@minprice and price<@maxprice
order by price
end

exec prod9 100 ,200
drop table product



