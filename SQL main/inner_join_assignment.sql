create table employees(department_id int not null,
                       first_name varchar(20)not null,
					   last_name varchar(20)not null,
					   emp_no int not null)
					   
insert into employees values(123,'prachi','dahiwale',1)
insert into employees values(456,'akansha','wasnik',2)
insert into employees values(789,'sayali','kapse',3)
select * from employees

create table department(department_id int,
                        department_name varchar(20)not null,
						manager_id int,
						location_id int )
						drop table employees
						drop ta
insert into department values(123,'manager',20,258)
insert into department values(456,'clerk',30,369)
insert into department values(789,'peun',40,147)
select * from department

select employees.department_id,employees.first_name,employees.last_name,employees.emp_no,
       department.department_id,department.department_name,department.manager_id,department.location_id
	   from employees
	   join department
	   on employees.department_id=department.department_id

