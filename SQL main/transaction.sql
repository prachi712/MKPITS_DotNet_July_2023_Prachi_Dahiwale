create table mkpits(student_id int not null,
                    student_name varchar(20)not null,
					fees int not null,
					total_students int)

insert into mkpits values(1,'prachi',65000,25)
insert into mkpits values(2,'mrunali',52000,12)
insert into mkpits values(3,'sayali',36000,41)
select *  from mkpits

begin transaction
insert into mkpits values(4,'piyali',45000,30)
update mkpits set student_name='vaibhavi' where fees=520
update mkpits set student_name='vrushali' where fees=45
commit transaction

