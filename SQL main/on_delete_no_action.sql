create table vendor(vendor_id int identity primary key,vendor_name varchar(20) not null,
                       group_id int not null,constraint fk foreign key(group_id)
					   references vendors_groups(group_id)on delete no action)
					   insert into vendor values('prachi',1)
					   select * from vendor
					   delete from vendors where vendors_id=1
					   select * from vendor
					   insert into vendors values('swati',2)
					   insert into vendors values('pratiksha',3)