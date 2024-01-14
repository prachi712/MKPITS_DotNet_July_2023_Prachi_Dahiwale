create table stores(store_id int  primary key,
                    store_name varchar(30)not null,
					phone int,
					email_address varchar(50)unique,
					sreet varchar(20) not null,
					city varchar(20) not null,
					state varchar(20)not null,
					zip_code int )
insert into stores values(1,'mkpits',1234,'mkpits@gmail.com','bardi','Nagpur','maharashtra',40502)

insert into  stores values(2,'ashishnx',5678,'ashish@gmail.com','mahal','bhopal','mp',78945)
select * from stores

create table staff(staff_id int primary key,
                   first_name varchar(20)not null,
				   last_name varchar(20)not null,
				   email_address varchar(50)unique,
				   phone int ,
				   active varchar(20)not null,
				   store_id int,
				   manager_id int)
insert into staff values(3,'prachi','dahiwale','prachi@gmail.com',4578,'present',2,143)
insert into staff values(4,'priya','mane','priya@gmail.com',7845,'absent',4,134)
select * from staff

create table categories(category_id int primary key,
                         category_name varchar(20))
insert into categories values(351,'five_star')
insert into categories values(981,'three_star')
select * from categories

create table brands(brand_id int primary key,
                    brand_name varchar(20)not null)
insert into brands values(20,'zara')
insert into brands values(30,'zudio')
select * from brands

create table productsss(product_id int ,
                        product_name varchar(20)not null,
						brand_id int,
						category_id int,
						model_year int,
						list_price int)
insert into productsss values(1,'dress',5,351,2023,2500)
insert into productsss values(2,'shirt',6,981,2024,2600)
select * from productsss

create table customersss(customer_id int primary key,
                         first_name varchar(20)not null,
						 last_name varchar(20)not null,
						 phone int,
						 email_address varchar(50)unique,
						 street varchar(20),
						 city varchar (20)not null,
						 state varchar(20)not null,
						 zip_code int)
insert into customersss values(10,'shweta','oswami',12347845,'shweta@gmail.com','nandanwan','bhandara','indore',47935)