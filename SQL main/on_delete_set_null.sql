create table pra(vendors_id int identity primary key,vendors_name varchar(20) not null,
                   group_id int null,
				   constraint fk5 foreign key(group_id)
				   references vendors_groups(group_id)on delete set null)
				  drop table pra
				  insert into vendors_groups values('prachi')
				  insert into vendors_groups values('swara')
				  insert into vendors values ('swaraj',2)
				  delete from  vendors  where group_id=2
				  select * from vendors_groups
				  select * from vendors