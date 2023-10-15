declare @num int ,@factorial int
set @factorial=1
set @num=6
while @num>=1
begin 
set @factorial=@factorial *@num
set @num=@num-1
end
select @factorial as FACTORIAL

--2. Create a stored procedure to generate multiplication tables up to a given number.
create proc MultiplicationTable    
@num int
as
begin        
    declare @i int, @mulresult int;     
    set @i = 1;    

        while @i <= 10     
        begin       
           set @mulresult = @num * @i;         
           print  cast(@num as varchar(30)) + ' * ' + cast(@i as varchar(10)) + ' = '+ cast(@mulresult as varchar(10));         
           set @i = @i + 1;     
        end
end

execute MultiplicationTable 5;

--3. Create a trigger to restrict data manipulation on EMP table during General holidays.
--Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", you cannot manupulate" 

create table Holidays
(holiday_date Date Primary Key, holiday_name varchar(30));
insert into holidays values
('2023-01-01','NewYear'),
('2023-08-15','Independence Day'),
('2023-10-27','Diwali'),
('2023-12-25','Christmas'),
('2023-10-15','Homieday');

Create trigger RestrictDataManiOH
ON Emp
FOR INSERT, UPDATE, DELETE 
AS 
begin    
declare @Holiday_name VARCHAR(50), @holiday_date DATE
set @holiday_date = CONVERT(DATE, GETDATE())
select @Holiday_name = Holiday_name     
from Holidays    
where holiday_date = @holiday_date 
If @holiday_name IS NOT NULL     
begin       
ROLLBACK TRANSACTION        
RAISERROR('Due to %s, you cannot manipulate data', 16, 1, @holiday_name)     
end
end 

insert into Emp values(7672,'Bhavagna','analyst',6767,'2013-07-09',8000,1000,10);

delete from emp where empno=1
update Emp
set sal = sal*1.10;