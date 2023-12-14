create table students(rno int,first_name varchar(20),address varchar(20))
insert into students values(1,'prachi','palandur')
insert into students values(2,'shweta','kondha')
insert into students values(3,'pooja','palandur')
insert into students values(4,'prachi','murmadi')
insert into students values(2,'shweta','nagar')
select distinct rno from students
select distinct first_name from students order by first_name
select first_name,address from students order by first_name
select first_name ,address from students order by first_name desc
