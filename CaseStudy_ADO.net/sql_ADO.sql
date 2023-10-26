create database CaseStudy
use CaseStudy
create table student(
 sid int primary key,
 sname varchar(25),
 sdob Date
 );
 create table course(
 cid int primary key,
 cname varchar(25)
 );
 create table enroll(
 sid int foreign key references student(sid)  ,
 cid int foreign key references course(cid) ,
 sname varchar(25),
 sdob Date,
 cname varchar(25),
 enrolldate Date,
 primary key (sid,cid)
 );
 select*from Student
 select*from Course
 select*from Enroll