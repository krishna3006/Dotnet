create table applicationusers
(
userid varchar(10) primary key,
username varchar(30) not null,
city varchar(30) not null,
password varchar(30) check(len(password) >5)
)select * from applicationusers