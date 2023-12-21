select * from product
truncate table product
insert into product values('book',100)
insert into product values('pen',300)
alter table product
add product_bundle int
sp_help product
alter table product
alter column product_price dec(10,2)
alter table product
drop column product_price
sp_rename 'product','product111111'
EXEC sp_rename 'product_name','product_na','COLUMN'