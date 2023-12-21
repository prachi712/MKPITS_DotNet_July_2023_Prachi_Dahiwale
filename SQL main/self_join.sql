create table kstudent(id int primary key identity,first_name varchar(20) not null,
                      last_name varchar(20)not null,city varchar(20)not null)
		insert into kstudent values('prachi','dahiwale','chichal'),
		                           ('swayam','chavhan','chichal'),
								   ('swara','jivtode','bhandara'),
								   ('shreys','jhgf','chichal')

								   select * from kstudent
		select s1.first_name,s2.last_name,s2.city
		from kstudent s1,kstudent s2
		where s1.id<>s2.id and
		s1.city=s2.city
		order by s2.city
		
								   
