drop table product
create table product(product_id int primary key identity,
                     product_name varchar(20)not null,
					 product_price int not null)
insert into product values('laptop',1000)
insert into product values('computer',200)
insert into product values('mouse',2000)
insert into product values('keyboard',3000)
select * from product
update product set product_price=5000
where product_name='laptop'
update product set product_price=6000
where product_name='machine' and product_price=600
select * from product
update product set product_price=70000
where product_name='computer'
update product set product_price=8000
where product_name='mouse' and product_price=2000
delete from product
where product_name='keyboard'
select * from product
delete from product 
where product_price=8000 and product_name='mouse'