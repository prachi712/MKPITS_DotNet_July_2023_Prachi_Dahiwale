create table product5(product_id int  primary key,
                      product_name varchar(20)not null,
					  unit_price DEC(10,2)check(unit_price>0),
					  discounted_price DEC(10,2)check(discounted_price>0),
					  check(discounted_price<unit_price))
insert into product5 values(1,'chipra',120,20)
select *  from product5
           insert into product5 values(9,'lala',20,10)