create table vendors_groups(group_id int identity primary key,
                             group_name varchar(100) not null)

create table vendors(vendors_name varchar (100) not null,
                      vendors_id int identity primary key,
					  group_id int identity primary key)
					  drop table vendors
	select * from vendors_groups
	drop table vendors
	create table vendors(vendors_name varchar(20) not null,vendors_id int  identity primary key,group_id int not null)
	select * from vendors
	insert into vendors(vendors_name,vendors_id)values('prachi',123)
	insert into vendors_groups values('mkpits')
	insert into vendors_groups values('raisonin')
	select * from vendors_groups
	insert into vendors(vendors_name,group_id)values('pra',1)
	select * from vendors
	drop table vendors
	create table vendors(vendors_name varchar(20) not null,vendors_id int identity primary  key,group_id int not null
	                       constraint fk_group foreign key(group_id)
						   references vendors_groups(group_id))
	insert into vendors(vendors_name,vendors_id)values('chipra',2)
	select * from vendors