create database codetest_5
use codetest_5
create table books(
id int primary key,
title varchar(45),
author varchar(50),
isbn bigint unique,
published_date date
);
insert into books values
(1,'My First SQL book','Mary Parker', 981483029127, '2012-02-22 12:08:17'),
(2,'My Second SQL book','John Mayerr', 857300923713, '1972-07-03 09:22:45'),
(3,'My Third SQL book','Cary Flint', 523120967812, '2015-10-18 14:05:44')

--fetch the details
select * from books where author like '%er'


create table reviewss(
id int,
book_id int,
reviewer_name varchar(50),
content varchar(40),
rating int,
publisher_date date
);
insert into reviewss values
(1,1,'John Smith','My first review',4,'2017-12-10 05:50:11.1'),
(2,2,'John Smith','My second review',5,'2017-10-13 15:05:12.6'),
(3,3,'Alice Walker','My third review',1,'2017-10-22 23:47:10')

--2
select * from reviewss
select books.title, books.author,reviewss.reviewer_name from books
inner join reviewss on books.author=reviewss.reviewer_name;
--3
select * from reviewss where rating>1

create table customer(
id int,
name varchar(40),
age int,
address varchar(90),
salary decimal
);
insert into customer values
(1,'Ramesh',32,'Ahmedabad',2000.00),
(2,'Khilan',25,'Delhi',1500.00),
(3,'kaushik',23,'Kota',2000.00),
(4,'Chaitali',25,'Mumbai',6500.00),
(5,'Hardik',27,'Bhopal',8500.00),
(6,'Komal',22,'MP',4500.00),
(7,'Muffy',24,'Indore',10000.00)

--same address
select * from customer where address like '%o%';


create table orders(
oid int,
odate date,
customer_id int,
amount decimal
);
insert into orders values
(102,'2009-10-08 00:00:00',3,3000),
(100,'2009-10-08 00:00:00',3,1500),
(101,'2009-11-20 00:00:00',2,1560),
(103,'2009-05-20 00:00:00',4,2060)

--samedate
select odate, count(DISTINCT customer_id) as total_customers from orders group by odate

create table employee(
id int,
name varchar(40),
age int,
address varchar(90),
salary decimal
);
insert into employee values
(1,'Ramesh',32,'Ahmedabad',2000.00),
(2,'Khilan',25,'Delhi',1500.00),
(3,'kaushik',23,'Kota',2000.00),
(4,'Chaitali',25,'Mumbai',6500.00),
(5,'Hardik',27,'Bhopal',8500.00),
(6,'Komal',22,'MP',null),
(7,'Muffy',24,'Indore',null)

--salary null
select lower(name) as LowercaseName from employee
where salary is null;

create table studentdetails(
registerno int,
name varchar(50),
age int,
qualification varchar(60),
mobileno decimal,
mail_id varchar(90),
location varchar(70),
gender varchar(30)
);
insert into studentdetails values
(2,'Sai',22,'B.E',9952836777,'Sai@gmail.com','Chennai','M'),
(3,'Kumar',20,'BSc',7890125648,'Kumar@gmail.com','Madurai','M'),
(4,'Selvi',22,'B.Tech',8904567342,'Selvi@gmail.com','Selam','F'),
(5,'Nisha',25,'M.E',7834672310,'Nisha@gmail.com','Theni','F'),
(6,'Sai Saran',21,'B.A',7890345678,'Saran@gmail.com','Madurai','F'),
(7,'Tom',23,'BCA',89012345675,'Tom@gmail.com','Pune','M')
--gender count
select gender as Gender,
count(*) as c
from studentdetails
group by gender;