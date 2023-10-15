create database Assignment2
use Assignment2
create table Emp(
empno int,
ename varchar(54),
job varchar(54),
mgrid int,
hiredate date,
sal decimal,
comm int,
deptno int
);
select*from Emp
create table Dept(
deptno int,
dname varchar(54),
loc varchar(54)
);
insert into Emp values
(7369 ,'SMITH ','CLERK',7902,'17-DEC-80 ',800, null, 20),
(7499  ,  'ALLEN ','SALESMAN',7698,'20-FEB-81 ',   	 1600   ,  300   , 30),
(7521 ,  'WARD	',  'SALESMAN',7698    ,	'22-FEB-81',  	 1250    , 500   , 30),
(7566 ,   'JONES',     'MANAGER',7839  , 	 	'02-APR-81 ',  	 2975 ,null,           20),
(7654,    'MARTIN  ', 'SALESMAN',7698   	,' 28-SEP-81  '	, 1250   , 1400    ,30),
(7698,'BLAKE ',   'MANAGER',7839 	,    	 '01-MAY-81  '    , 2850     ,null,       30),
(7782 ,'CLARK ','MANAGER',7839    ,'	09-JUN-81  ', 	 2450   ,null,         10),
(7788 ,'SCOTT ','ANALYST',7566   ,'	 19-APR-87     ', 3000  ,null,           20),
(7839 ,'KING ','PRESIDENT',null,'     			 17-NOV-81   ',   5000  ,null,           10),
(7844 ,'TURNER ','SALESMAN',7698 ,  	'08-SEP-81  ',  	 1500  ,    0 ,    30),
(7876 ,'ADAMS ','CLERK',        	7788   ,' 	23-MAY-87  ',      1100    ,null    ,    20),
(7900 ,'JAMES ','CLERK',      		 7698   ,'	 03-DEC-81 ', 	 950   ,null,          30),
(7902 ,'FORD  ','ANALYST',   		  7566   ,'	 03-DEC-81 ',  	 3000,null,            20),
(7934 ,'MILLER ','CLERK',     		 7782    ,'	23-JAN-82',	 1300 ,null,           10)
insert into dept values
(10    ,' ACCOUNTING  ','  NEW YORK '),
(20    ,' RESEARCH ','     DALLAS '),
(30    ,' SALES ','        CHICAGO '),
(40    ,' OPERATIONS ','   BOSTON ')
--1. List all employees whose name begins with 'A'. 
select ename from emp where ename like 'A%'
--2. Select all those employees who don't have a manager. 
select job from emp where job<>'manager'
select*from emp where job<>'manager'
--3. List employee name, number and salary for those employees who earn in the range 1200 to 1400. 
select ename, empno,sal from emp where sal between 1200 and 1400
--4. Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise. 
select *from emp where deptno =20
update emp set sal=sal*1.10 where deptno =20
select*from emp where deptno=20
--5. Find the number of CLERKS employed. Give it a descriptive heading. 
select count(*) as no_of_clerks from emp where job='clerk'
--7. List the employees with the lowest and highest salary. 
select*from emp where sal=(select min(sal) from emp)
union
select*from emp where sal=(select max(sal) from emp)
--8. List full details of departments that don't have any employees. 
--9. Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name. 
select ename, sal from emp where job='analyst' and sal >1200 and deptno=20 order by ename asc
--10. For each department, list its name and number together with the total salary paid to employees in that department. 
--11. Find out salary of both MILLER and SMITH.
select sal from emp where ename='miller'
union 
select sal from emp where ename='smith'
select sal from emp where ename in ('miller','smith')
--12. Find out the names of the employees whose name begin with �A� or �M�. 
select * from emp where ename like 'a%' or ename like 'm%'
--13. Compute yearly salary of SMITH. 
select sal=sal*12 from emp where ename='smith'
--14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850. 
select ename ,sal from emp where sal< 1500 or sal>2850
--15. Find all managers who have more than 2 employees reporting to them
--6. Find the average salary for each job type and the number of people employed in each job. 
select avg(sal) as avg_sal , job, count(job)  as c_job from emp
group by job 
--8. List full details of departments that don't have any employees. 
select*from dept where deptno not in (select deptno from emp)
--10. For each department, list its name and number together with the total salary paid to employees in that department. 
select  dname , dept.dname, sum(sal) as sum_sal from dept join emp 
on dept.deptno=emp.deptno group by dept.dname 
--15. Find all managers who have more than 2 employees reporting to them
select e.mgrid as manager_id, n.ename as manager_name , count(*) as emp_count from emp e
join emp n on e.mgrid=n.empno group by e.mgrid, n.ename having count(*)>2;







