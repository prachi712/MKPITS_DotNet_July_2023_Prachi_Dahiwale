create table tableinvoicedetail(cgst_value int not null,
                                sgst_value int not null,
								igst_value int not null,
								total_amount int not null)

insert into tableinvoicedetail values(3600,3600,3600,67200)
select * from tableinvoicedetail