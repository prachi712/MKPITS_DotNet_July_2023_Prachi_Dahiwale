create trigger deep 
on emp
for
insert,update ,delete
as 
print 'you can not insert,update and delete this table i'
rollback;