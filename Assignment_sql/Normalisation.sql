create database Client_Rental
use Client_Rental
create table Client_Rentall(
ClientNo varchar(max),
propertyno varchar(max),
cname varchar(max),
paddress varchar(max),
rentstart date,
rentfinish date,
rent int,
ownerno varchar(max),
oname varchar(max)
);

drop table Client_Rentall

insert into Client_Rentall values
('CR76','PG4','John Kay', '6 lawrence St,Glasgow', '1-Jul-00','31-Aug-01', 350, 'CO40', 'Tina Murphy'),
('CR76','PG16','John Kay', '5 Novar Dr,Glasgow', '1-Sep-02','1-Sep-02',450, 'CO93', 'Tony Shaw'),
('CR56','PG4','Aline Stewart', '6 lawrence St,Glasgow', '1-Sep-99','10-Jun-00', 350, 'CO40', 'Tina Murphy'),
('CR56','PG36','Aline Stewart', '2 MAnor Rd,Glasgow', '10-Oct-00','1-Dec-01', 370, 'CO93', 'Tony Shaw'),
('CR56','PG16','Aline Stewart', '5 Novar Dr,Glasgow', '1-Nov-02','1-Aug-03', 450, 'CO93', 'Tony Shaw')

create table clientNo(
clientno varchar(10) primary key,
cname varchar(20)
);
insert into clientNo values
('cr76','john kay'),
('cr56','aline stewart')
select * from clientNo

 
create table ownerNo(
ownerno varchar(10)primary key,
oname varchar(20)
);
insert into ownerNo values
('co40','tina murphy'),
('co93','tony shaw')
select * from ownerNo


create table propertyNo(
propertyno varchar(10)primary key,
paddress varchar(30),
rent bigint,
ownerno varchar(10)
);
insert into propertyNo values
('pg4','6 lawerence st.glasgow',350,'co40'),
('pg16','5 novar dr glasgow ',450,'co93'),
('pg36','2 manor rd.glasgow ',370,'co93')
select * from propertyno

create table rentalno(
clientno varchar(10) foreign key references clientno(clientno),
propertyno varchar(10) foreign key references propertyno(propertyno),
rentstart date,
rentfinish date
);
insert into rentalno values
('cr76','pg4','2000-07-01','2001-08-31'),
('cr76','pg16','2002-09-01','2003-09-01'),
('cr56','pg4','1999-09-01','2000-06-10'),
('cr56','pg36','2000-10-10','2001-12-01'),
('cr56','pg16','2002-11-01','2003-08-01')
select * from rentalno
