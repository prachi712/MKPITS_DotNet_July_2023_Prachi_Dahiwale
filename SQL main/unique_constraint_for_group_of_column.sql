create table person_skill(id int primary key,
                          skill_id int,
						  updated_at DateTime,
						  unique(id,skill_id))
insert into person_skill values(1,2,'2023-2-1')
select * from person_skill