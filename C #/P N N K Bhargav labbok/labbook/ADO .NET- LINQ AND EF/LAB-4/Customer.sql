IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='CUSTOMER')
DROP TABLE customer 

create table customer
(
customerid int  primary key,
customername varchar(50),
city varchar(30),
creditlimit numeric(10,2)
)
INSERT INTO customer 
values
(3,'Bharath','Banglore',2222)


select * from customer

sp_helptext prcStudentauto	
