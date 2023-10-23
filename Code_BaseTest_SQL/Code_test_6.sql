
use Assignment2
create table Code_Employee(
 empno int primary key,
 empname varchar(35),
 empsal decimal(10,2) check (empsal >=25000),
 emptype char(1)
 );

create procedure AddNewEmployee(
    @empname varchar(25),
    @empsal decimal(10, 2),
    @emptype char(1)
)
as
begin
declare @new_empno int;
select @new_empno=isnull(max(empno),0)+1 from Code_Employee
insert into Code_Employee(empno, empname,empsal, emptype) values
(@new_empno, @empname, @empsal, @emptype)
select * from Code_Employee where empno=@new_empno
end
select *from Code_Employee



-- Declare the variables for the cursor
declare @empno numeric(4);
declare @sal int;
declare employee_cursors cursor for
select empno, sal
from emp
where deptno = 10;
open employee_cursors;
fetch next from employee_cursors into @empno, @sal;
while @@FETCH_STATUS = 0
begin
 update emp
    set sal= sal * 1.15
    where empno = @empno;
 fetch next from employee_cursors into @empno, @sal;
end
close employee_cursors;
deallocate employee_cursors;
select * from Emp where deptno = 10;