create table productu(product_id int primary key,
                      product_name varchar(20)not null,
					  unit_price DEC(10,2)not null)
					  insert into productu values(1,'pra',120)
					  insert into productu values(2,'shiva',542)
					  insert into productu values(3,'paru',142)
					  alter table productu
					  add constraint positive1_price check (unit_price>0)
					  select * from productu