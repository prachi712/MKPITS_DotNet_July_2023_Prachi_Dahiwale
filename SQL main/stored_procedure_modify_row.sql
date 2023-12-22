alter procedure prod3
as begin
insert into product values(3,'charger')
select * from product

end

exec prod3
