create table cproduct1(productname varchar(20) not null,
                      price int not null)

insert into cproduct1 values('mouse',100)
insert into cproduct1 values('keyboard',200)
insert into cproduct1 values('pen',300)
select * from cproduct1

declare
@product_name3 varchar(max),
@list_price3 decimal

declare cursor_product3 cursor
for select 
         productname,price
		 from cproduct1

open cursor_product3

fetch next from cursor_product3 into
@product_name3,
@list_price3

print @product_name3+CAST(@list_price3 as varchar)


while @@fetch_status=0
begin
fetch next from cursor_product3 into
@product_name3,
@list_price3

print @product_name3+cast(@list_price3 as varchar)
end

drop table cproduct1

close cursor_product3 
deallocate cursor_product3
