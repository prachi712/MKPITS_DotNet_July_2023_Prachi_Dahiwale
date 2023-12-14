create table product(productid int,productname varchar(20))
insert into product values(1,'computer')
insert into product values(2,'laptop')
insert into product values(3,'mouse')
insert into product values(4,'cpu')
insert into product values(5,'keyboard')
select top 2 productname,productid from product order by productname desc;
drop table product
