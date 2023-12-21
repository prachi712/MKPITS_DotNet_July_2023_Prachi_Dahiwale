drop table student
create table student(
                     admission_no varchar(20) not null,
					 first_name varchar (20) not null,
					 last_name varchar (20) not null,
					 age int)

create table fee(admission_no varchar(20) not null,
                 course_name varchar (20) not null,
				 amount_paid int)

insert into student(admission_no,first_name,last_name,age)
                    values
					('87','prachi','dahiwale',1),
					('41','swara','sontakke',13),
					('784','swayam','chvhan',4),
					('412','priya','mate',23),
					('985','aayushree','shende',52)
                                   drop table student
insert into fee(admission_no,course_name,amount_paid)
               values
			   ('87','dotnet',300000),
			   ('41','java',400000),
			   ('32','python',84512),
			   ('65','sql',6985),
			   ('10','javascript',745236)
select  * from student  
select * from fee
select student.admission_no,student.first_name,student.last_name,student.age,fee.course_name,fee.amount_paid
from student cross join fee