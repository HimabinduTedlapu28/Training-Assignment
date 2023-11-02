create table books(
id int primary key,
Title varchar(50),
Author varchar(50),
isbn bigint,
Publisheddate DateTime,
)
insert into books values(1, 'My first sql book','Mary parker',981483029127,'2012-02-22 12:08:17'),
(2,'My second sql book', 'John mayer',857300929127,'1972-07-03 09:22:43'),
(3,'My third sql book','Cary Flint',523120967812,'2015-10-18 14:05:44')
select * from books
--Write a query to fetch the details of the books written by author whose name ends with er
select * from books where Author like '%er'
--Display the Title ,Author and ReviewerName for all the books from the above table

select books.title,books.author,reviews.reviewername
from books 
inner join reviews on books.id = reviews.id


create table reviews (
id int ,
bookid int,
reviewername varchar(50),
content varchar(50),
roting int,
publishingdate DateTime
)
insert into reviews values (1,1, 'John Smith','My first Review',4,'2017-12-10 05:50:11'),
(2,2,'John Smith','My Second Reviews',5, '2017-10-13 15:05:12'),
(3,3,'Alice Walker', 'Another review',1, '2017-10-22 23:47:10')
select * from reviews

select b.title , b.author, r.reviewername




--Display the reviewer name who reviewed more than one book.
select reviewername from reviews
group by reviewername 
having count(Distinct bookid )>1

--5
create table employeesss (
id int,
Names varchar(50),
 age int,
 Addresses varchar(50),
 salary int
 )
 insert into employeesss values (1, 'Ramesh', 32, 'Ahmedabad',2000),
 (2, 'Khilan',25,'Delhi',1500),
 (3, 'Kaushik',23, 'kota', 2000),
 (4, 'Chaitali', 24,'Mumbai',6500),
 (5, 'Hardik',27, 'Bhopal', 8500),
 (6, 'KOmal',22,'Mp', null),
 (7,'Muffy', 24, 'Indore', null)

 select * from employeesss

  select Lower(names ) from employeesss where salary is null

  select gender , count(*) as total from studentdetails 
  group by gender;

  
  update employeesss
  set salary = 10000 where names = 'Muffy'
  select names, Addresses from employeesss where Addresses like '%o%'

  select * from employeesss

  create table orderss(
  orderid int,
  Dates datetime,
  customerid int, 
  amount int
  )
  insert into orderss values(102, '2009-10-08 00:00:00',3, 3000),
  (100, '2009-10-08 00:00:00',3, 1500),
  (101, '2009-11-20 00:00:00',2, 1560),
  (103, '2008-05-20 00:00:00', 4, 2060)
  select * from orderss

  --Write a query to display the Date,Total no of customer placed order on same Date
  select Dates, count(customerid) as total from orderss
  group by dates;



