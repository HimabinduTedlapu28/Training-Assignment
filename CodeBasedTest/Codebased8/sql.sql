create database moviedb 
--- Create a table called Movie(Mid,Moviename,DateofRelease)
create table Movie(
Mid int,
Moviename varchar(50),
DateofRelease date
)
select * from Movie
insert into Movie values(1, 'RRR', '2023-05-10'),
(2,'Bahubali','2017-10-20'),
(3,'Jailer','2023-05-12'),
(4,'Jawan','2022-03-04')
