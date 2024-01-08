create table tablestate(state_id int primary  key not null,
                        state_name varchar(20)not null,
						nation_id int,
						foreign key(nation_id)
						references tablenation(nation_id))

insert into tablestate values(101,'Andhra pradesh',1)
insert into tablestate values(102,'Punjab',1)
insert into tablestate values(103,'California',2)
insert into tablestate values(104,'florida',2)
insert into tablestate values(105,'koshi',3)
insert into tablestate values(106,'bagmati',3)
insert into tablestate values(107,'colombo',4)
insert into tablestate values(108,'ratnapura',4)
select * from tablestate

drop table tablestate
