create table account(
                     account_name varchar(50)not null,
					  occupation varchar(50)not null,
					  account_phone int,
					   education varchar(50)not null,
					   Age int not null,
					 account_gender varchar(20)not null);
					
					
					
					 references Agent(account_phone))

insert into account values(123456789,'saving','male','farmer','undergraduated',100000,258)
select * from account