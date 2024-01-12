create table Agent(account_id int  not null,
                   account_name varchar(50)not null,
				   account_pass varchar(20)not null,
				   account_phone int primary key not null,
				   address  varchar(50)not null)

insert into agent values(123,'Prachi Dahiwale','prachi',789,'lakhandur')
insert into agent values(456,'sayyam Dahiwale','sayyam',258,'palandur')
select * from agent

drop table agent