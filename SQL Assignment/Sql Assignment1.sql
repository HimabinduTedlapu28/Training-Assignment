create table client(
clientid int primary key ,
cname varchar(40) not null,
address varchar(30),
email varchar(30) unique ,
phone int ,
business varchar(20) not null
)
insert into client values(1001, 'ACME Utilities','Noida','contact@acmeutil.com',9567880032, 'manufacturing'),

(1002, 'Trackon Consultants', 'Mumbai', 'consult@trackon.com', 8734210090 ,'Consultant'),

(1003, 'MoneySaver Distributors', 'Kolkata', 'save@moneysaver.com', 7799886655, 'Reseller'),

(1004, 'Lawful Corp', 'Chennai', 'justice@lawful.com', 9210342219, 'Professional')

select * from client

create table employeess(
empno int primary key,
ename varchar(20) not null,
job varchar(15),
salary int,
deptno int foreign key references departments (deptno)
);
select * from employeess
insert into employeess values(7001, 'sandeep', 'analyst', 250000, 10), 
(7002, 'rajesh', 'designer', 30000, 10),
(7003, 'madhav', 'developer', 40000, 20),
(7004, 'manoj', 'developer', 40000, 20),
(7005, 'abhay', 'designer', 35000, 10),
(7006,'uma', 'tester', 30000, 30),
(7007,'gita', 'tech.writer',30000, 40),
(7008,'priya', 'tester', 35000, 30),
(7009, 'nutan', 'developer', 45000, 20),
(7010, 'smita', 'analyst', 20000, 10),
(7011, ' anand', 'project mgr',65000, 10)



create table departments (
deptno int primary key,
danme varchar(15),
loc varchar(20)
)
insert into departments values(10, 'design', 'pune'),
(20, 'development','pune'),
(30, 'testing', 'mumbai'),
(40, 'document', 'mumbai')
select * from departments


create table project(
projectid int primary key,
descr varchar(30),
startdate date,
planned_end_date date,
actual_end_date date not null,
budget int,
clientid int foreign key references client(clientid)

)
alter table project
add actual_end_date date
update project
set actual_end_date = '2011-10-31'
where projectid = 401;

select * from project
insert into project values(401, 'inventory', 01-04-11, 01-10-11, 31-10-11, 150000,1001),
(402, 'accounting',01-08-11,01-01-12, ,500000,1002) 
(403, 'payroll','2011-12-31','2011-12-31',75000,1003),
(404, 'contact mgmt','2011-11-01','2011-12-31',50000,1004)



create table empProjectTasks(
projectid int foreign key references project (projectid)  ,
empno int foreign key references employeess(empno), 
startdate date ,
enddate  date not null,
task varchar(30) not null,
status varchar(30) not null,
primary key(projectid)
)


select * from empProjectTasks
insert into empProjectTasks values(401, 7001, '2011-04-01', '2011-04-20', 'system analysis', 'completed'),
(401, 7002, '2011-04-01','2011-06-15','system design','completed'),
(401, 7003,'2011-06-01','2011-06-15','coding','completed'),
(401, 7004,'2011-06-18','2011-09-01','coding','completed'),
(401, 7006,'2011-09-03','2011-09-15','Testing','completed'),
(401, 7009,'2011-09-18','2011-10-05','Code Change','Completed'),
(401,7008, '2011-10-06','2011-10-16','Testing','Completed'),
(401,7007, '2011-10-06','2011-10-22','Documentation','Completed'),
(401,7011,'2011-10-22', '2011-10-31' ,'Sign off','Completed'),
(402,7010,'2011-08-01','2011-08-20','System Analysis', 'Completed'),
(402, 7002, '2011-08-22','2011-09-30', 'System Design', 'Completed'),
(402, 7004, '2011-10-01',null , 'Coding', 'In Progress')




