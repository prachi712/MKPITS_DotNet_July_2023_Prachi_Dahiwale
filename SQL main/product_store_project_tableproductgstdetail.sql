create table tableproductgstdetail(product_gst_id int not null,
                                   gst_detail_name varchar(20)not null,
								   cgst int not null,
								   sgst int not null,
								   igst int not null)

insert into tableproductgstdetail values(601,'Ac and Fridge',14,14,14)
insert into tableproductgstdetail values(602,'computer',9,9,9)
insert into tableproductgstdetail values(603,'printers',9,9,9)
insert into tableproductgstdetail values(604,'mobiles',6,6,6)
select * from tableproductgstdetail
