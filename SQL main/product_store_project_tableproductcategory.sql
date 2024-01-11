create table tableproductcategory(product_category_id int primary key,
                                  product_type_name varchar(20)not null,
								  product_gst_id int not null)

insert into tableproductcategory values(1001,'computers',602)
insert into tableproductcategory values(1002,'mobile',604)
insert into tableproductcategory values(1003,'printer',603)
insert into tableproductcategory values(1004,'Ac and Fridge',601)
select * from tableproductcategory