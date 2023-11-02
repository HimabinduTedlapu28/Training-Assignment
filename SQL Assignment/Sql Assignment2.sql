create table department(
deptno int primary key,
dname varchar(50),
loc  varchar(50)
)
select * from department
insert into department values(10 ,'ACCOUNTING', 'NEW YORK' ),
(20,'RESEARCH', 'DALLAS'), 
(30, 'SALES' ,'CHICAGO'), 
(40,' OPERATIONS','BOSTON ')

create table emp(
empno int primary key,
ename varchar(50),
job varchar(50),
mgrid int,
hiredate varchar(50),
sal int,
deptno int foreign key references department(deptno)
);
select * from emp
alter table emp
add  comm int

insert into emp values(7369, 'SMITH', 'CLERK',7902 ,'1980-12-08',800,20),
(7499,'ALLEN',' SALESMAN ', 769,'1981-02-20', 1600,30),
(7521 , 'WARD',	'SALESMAN', 7698 ,'1981-02-22', 1250,30),
(7566 ,'JONES', 'MANAGER ', 7839 ,'1981-04-02', 2975,20),
(7654 , 'MARTIN', 'SALESMAN', 7698,'1981-09-28', 1250, 30),
(7698,	'BLAKE ' ,'MANAGER' ,7839 ,'1981-05-01', 2850 ,30),
(7782 , 'CLARK', 'MANAGER', 7839 ,'1981-06-09', 2450 ,10),
(7788 ,	'SCOTT', 'ANALYST',7566 ,'1987-04-19',3000 ,20)

insert into emp values(7839 , 'KING','PRESIDENT',null,'1981-11-17',5000 , 10)
insert into emp values(7844 ,'TURNER','SALESMAN',7698 , '1981-09-08', 1500 ,30),
(7876  ,'ADAMS','CLERK',7788 ,'1987-05-23', 1100 , 20),
(7900 ,'JAMES', 'CLERK', 7698 ,'1981-12-03', 950,30),
(7902 ,'FORD','ANALYST ', 7566 ,'1981-12-03', 3000 ,20),
(7934 , 'MILLER', 'CLERK', 7782,'1982-01-23',1300, 10)

update emp
set comm = 0
where ename = 'turner';

--1.employee name begins with A
select * from emp where ename like 'A%'

--2.employee who don't have manager
select * from emp where mgrid is null

--3.employee name, number and salary for those employees who earn in the range 1200 to 1400
select ename,empno,sal from emp where sal between 1200 and 1400

--4.Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has
--been done by listing all their details before and after the rise.
select ename, (sal*0.1) as 'new sal' from emp where deptno = 20


-- 5.number of CLERKS employed. Give it a descriptive heading
select count(job) from emp where job = 'clerk'

--6.the average salary for each job type and the number of people employed in each job. 
select job, avg(sal) as 'average salary', count(job) as 'no of employed' from emp 
group by  job


--7.the employees with the lowest and highest salary
select  max(sal) as maxsalary, min(sal) as minsalary from emp 

--8.full details of departments that don't have any employees
select* from department where deptno = 40

--9.the names and salaries of all the analysts earning more than 1200 who are
--based in department 20.Sort the answer by ascending order of name. 
select ename,sal,job from emp where job like 'analyst' and deptno = 20 and sal > 1200
order by ename

--10.For each department, list its name and number together with the total salary 
--paid to employees in that department.

select deptno, sum(sal) as 'total salary', count(job) as 'no of employed'  from emp
group by  deptno
select * from department

--11.Find out salary of both MILLER and SMITH
select sal,ename  from emp where ename like  'miller' or ename like 'smith'

--12.Find out the names of the employees whose name begin with ‘A’ or ‘M’
select ename from emp where ename like 'A%' or ename like'm%'


--13.Compute yearly salary of SMITH.
select (sal *12) as 'annual salary' from emp where ename ='smith'

--14.List the name and salary for all employees whose salary is 
--not in the range of 1500 and 2850
select ename, sal from emp where sal not between 1500 and 2850


--15. Find all managers who have more than 2 employees reporting to them
select mgrid, count(*) as employees from emp
group by mgrid
having count(*) > 2
