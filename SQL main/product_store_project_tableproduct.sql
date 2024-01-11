create table tableproduct(product_id int primary key,
                          product_name varchar(20)not null,
						  product_category_id int,foreign key(product_category_id)
						  references tableproductcategory(product_category_id),
						  product_price int not null)

insert into tableproduct values(210,'Apple',1002,40000)
insert into tableproduct values(211,'Lenevo',1002,25000)
insert into tableproduct values(212,'Samsung',1003,50000)
insert into tableproduct values(213,'IFB',1004,20000)
insert into tableproduct values(214,'LG',1004,30000)
insert into tableproduct values(215,'sony',1001,60000)
select * from tableproduct
