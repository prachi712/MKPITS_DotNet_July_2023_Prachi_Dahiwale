create table vendor3(vendor_id int identity primary key,vendor_name varchar(20) not null,group_id int not null,
                         constraint fk1 foreign key(group_id)
						 references vendors_groups (group_id)
						 on delete cascade)
						 insert into vendors values('prachi',1)
						 select * from vendors
						 delete from vendors where group_id=3
						 select * from vendors
						 select  * from vendor3

















