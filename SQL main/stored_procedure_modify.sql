create table product(
                     productid int,productname varchar(20))
					 insert into product values(1,'mouse')
					 insert into product values(2,'keyboard')
					 select * from product
create procedure prod3
as begin
select * from  product
where productname='mouse'
end

exec prod3

alter procedure prod3
as begin
select productname,productid from product
order by productid
end

exec prod3
