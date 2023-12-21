create table students(admission_no int,
                      rollno int,
					  stud_name varchar(20) not null,
					  stud_attendence varchar(20) not null)

create table admit(admission_no int,
                   admission_process varchar(20) not null,
				   admission_fee int)

				   drop table students
insert into students(admission_no,rollno,stud_name,stud_attendence)
                       values
					   (10,1,'priyali','present'),
					   (11,2,'piyali','absent'),
					   (12,3,'kiran','present')
					   
insert into admit(admission_no,admission_process,admission_fee)
                  values
				  (18,'capround',2000),
				  (17,'management',5000),
				  (12,'cap',7000)

				  select * from students
				  select * from admit
	select students.admission_no,students.rollno,students.stud_name,students.stud_attendence,admit.admission_process,admit.admission_fee
	from students
	full outer join admit
	on students.admission_no=admit.admission_no