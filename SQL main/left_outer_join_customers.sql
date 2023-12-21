create table customers(cust_id int,
                       cust_name varchar(20) not null,
					   cust_lastname varchar(20)not null,
					   age int)

create table customer222(cust_id int,
                         cust_product varchar(20) not null,
						 price int)

insert into customers(cust_id,cust_name,cust_lastname,age)
                      values
					  (1,'pranjali','dhande',21),
					  (2,'pranita','kolte',23),
					  (3,'padma','sahare',36),
					  (4,'padmavati','mate',20)

insert into customer222(cust_id,cust_product,price)
                        values
						(1,'mouse',200),
						(3,'laptop',400),
						(4,'keyboard',500)
	select * from customers
	select * from customer222
select customers.cust_id,customers.cust_name,customers.cust_lastname,customers.age,customer222.cust_product,customer222.price
from customers
left outer join customer222
on customers.cust_id=customer222.cust_id

