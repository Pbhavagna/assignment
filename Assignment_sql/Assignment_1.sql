create database Assignment1
use Assignment1;
create table Clientss(
Client_ID int primary key,
Cname varchar(40) not null,
Address varchar(30),
Email varchar(30) unique,
Phone bigint,
Business varchar(20) not null
);
create table Employees(
Empno int primary key,
Ename varchar(20) not null,
Job varchar(15),
Salary int check (Salary>0),
Deptno int foreign key references Departmentss(deptno)
);
select *from Employees
create table Departmentss(
Deptno int  unique,
Dname varchar(15) not null,
Loc varchar(20)
);
create table Projectss(
Project_ID int primary key,
Descr varchar(30) not null,
Start_Date date,
Planned_End_Date date,
Actual_End_date date, check (Actual_End_date>Planned_End_Date),
Budget decimal check (Budget>0),
Client_ID int foreign key references Clientss(Client_ID)
);
select *from projectss
drop table EmpProjectTasks
create table EmpProjectTasks(
Project_ID int foreign key references Projectss(Project_ID),
Empno int foreign key references Employees(Empno),
Start_Date date,
End_Date date,
Tas varchar(25) not null,
Status varchar(15) not null
--primary key (project_id,empno)
);

insert into Clientss values
(1001,'ACME Utilities', 'Noida', 'contact@acmeutil.com', 9567880032, 'Manufacturing'),
(1002,'Trackon Consultants', 'Mumbai' , 'consult@trackon.com', 8734210090, 'Consultant'),
(1003, 'MoneySaver Distributors','Kolkata', 'save@moneysaver.com', 7799886655, 'Reseller'),
(1004, 'Lawful Corp', 'Chennai','justice@lawful.com',9210342219, 'Professional')
insert into Employees values
(7001,'Sandeep','Analyst',25000,10),
(7002,'Rajesh','Designer',30000,10),
(7003,'Madhav','Developer',40000,20),
(7004,'Manoj','Developer',40000,20),
(7005,'Abhay','Designer',35000,10),
(7006,'Uma','Tester',30000,30),
(7007,'Gita','Tech.Writer',30000,40),
(7008,'Priya','Tester',45000,30),
(7009,'Nutan','Developer',45000,20),
(7010,'Smita','Analyst',20000,10),
(7011,'Anand','Project Mgr',65000,10)
insert into Departmentss values
(10,'Design','Pune'),
(20,'Development','Pune'),
(30,'Development','Mumbai'),
(40,'Document','Mumbai')
insert into Projectss values
(401,'Inventory','01-Apr-11','1-Oct-11','31-Oct-11',150000,1001),
(402,'Accounting','01-Aug-11','01-Jan-12',null,500000,1002),
(403,'Payroll','01-Oct-11','31-Dec-11', null, 75000,1003),
(404, 'Contact Mgmt','01-Nov-11','31-Dec-11',null,50000,1004)
select *from projectss
insert into EmpProjectTasks values
(401,7001,'01-Apr-11','20-Apr-11','System Analysis','Completed'),
(401,7002,'21-Apr-11','30-May-11','System Design','Completed'),
(401,7003,'01-Jun-11','15-Jul-11','Coding','Completed'),
(401,7004,'18-Jul-11','01-Sep-11','Coding','Completed'),
(401,7006,'03-Sep-11','15-Sep-11','Testing','Completed'),
(401,7009,'18-Sep-11','05-Oct-11','Code Change','Completed'),
(401,7008,'06-Oct-11','16-Oct-11','Testing','Completed'),
(401,7007,'06-Oct-11','22-Oct-11','Documentation','Completed'),
(402,7011,'22-Oct-11','31-Oct-11','Sign off','Completed'),
(402,7010,'01-Aug-11','20-Aug-11','System Analysis','Completed'),
(402,7002,'22-Aug-11','30-Sep-11','System Design','Completed'),
(402,7004,'01-Oct-11',null,'Coding','In Progress')

insert into EmpProjectTasks values(402,7004,'01-Oct-11',null,'Coding','In Progress')

select * from EmpProjectTasks;
 












