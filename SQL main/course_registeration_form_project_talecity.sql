create table tablecity(city_id int primary key not null,
                       city_name varchar(20)not null,
					   state_id int,
					   foreign key(state_id)
					   references tablestate(state_id))

insert into tablecity values(1001,'vishakhapattanam',101)
insert into tablecity values(1002,'vijayawada',101)
insert into tablecity values(1003,'guntur',101)
insert into tablecity values(1004,'amritsar',102)
insert into tablecity values(1005,'jalandhar',102)
insert into tablecity values(1006,'chandigarh',102)
insert into tablecity values(1007,'los angeles',103)
insert into tablecity values(1008,'san jose',103)
insert into tablecity values(1009,'san diego',103)
insert into tablecity values(1010,'jacksonville',104)
insert into tablecity values(1011,'miamii',104)
insert into tablecity values(1012,'tampa',104)
insert into tablecity values(1013,'damak',105)
insert into tablecity values(1014,'dharan',105)
insert into tablecity values(1015,'biratnagar',105)
insert into tablecity values(1016,'banepa',106)
insert into tablecity values(1017,'haratpur',106)
insert into tablecity values(1018,'hetauda',106)
insert into tablecity values(1019,'grandpass',106)
insert into tablecity values(1020,'borellha',106)
insert into tablecity values(1021,'pettah',1017)
insert into tablecity values(1022,'balangoda',107)
insert into tablecity values(1023,'kolonna',108)

drop table tablecity

select * from tablecitys