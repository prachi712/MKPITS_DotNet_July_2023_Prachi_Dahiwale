select * from fproduct
select productname,quantity,price 
from fproduct
where price=(
select max(price) as "maximum price" 
from fproduct)


select productname,
max(price) as "maximum price"
from fproduct
group by productname
having max(price) >400