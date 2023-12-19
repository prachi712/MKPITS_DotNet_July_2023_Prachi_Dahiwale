create table person4(person_id int  primary key,
                      first_name varchar(20)not null,
					  last_name varchar(20)not null,
					  email_address varchar(20) unique)
insert into person4 values(1,'prachi','dahiwale','ptg@gmail.com')
insert into person4 values(2,'swara','chavhan','swarr@gmail.com')
select * from person4
drop table person4