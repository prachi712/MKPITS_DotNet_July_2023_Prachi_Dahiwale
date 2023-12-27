create table ccustomer(custid int not null,
                       custname varchar(20)not null)

insert into ccustomer values(1,'prachi')
insert into ccustomer values(2,'samantha')
insert into ccustomer values(3,'kiara')
select * from ccustomer
drop table ccustomer

declare 
@cust_id1 decimal,
@cust_name varchar(max)

declare cursor_customer1 cursor
for select custid,custname
from ccustomer
where custid=3

open cursor_customer1
fetch next from cursor_customer1 into
@cust_id1,
@cust_name

print @cust_id1+cast(@cust_name as varchar)
while @@FETCH_STATUS=0
begin fetch next from cursor_customer1 into
@cust_id1,
@cust_name

print @cust_id1+cast(@cust_name as varchar)
end

drop table ccustomer