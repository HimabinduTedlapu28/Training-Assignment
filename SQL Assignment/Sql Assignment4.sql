create table Holiday(
Holidaydate varchar(50),
HolidayName varchar(50)
)
update emp 
set sal = 20
select * from Holiday
insert into Holiday values('15 Aug','Independence Day'),
('26-Jan', 'Republic Day'),
('24-Oct', 'Dussehra'),
('02-Oct ', 'Gandhi Jayanthi')
insert into Holiday values('13-oct','general Holiday')
select * from emp

create trigger trgholiday2
on emp
for insert
as
begin
declare @today int 
select @today = datename(WEEKDAY,GETDATE());
if @today = 'Holidaydate'
begin
print' No data is inserted' + cast(@today as varchar(20))
end
end

insert into emp values (1,'ajay','clerk',123,'2001-12-12',200,10,null)


create procedure multiplication
@maxnumber int
as
begin
declare @a int
declare @b int
declare @res int
set  @a = 1
while @a <= @maxnumber
begin
set @b =1
PRINT 'Multiplication Table for ' + CAST(@a AS VARCHAR) + ':'
while @b <= @maxnumber
begin
set @a=1
PRINT CAST(@b AS NVARCHAR(10)) + ' * ' + CAST(@a AS NVARCHAR(10)) + ' = ' + CAST(@b * @a AS NVARCHAR(10));
SET @a = @a + 1;
END
SET @b = @b + 1;
end
end

execute multiplication@maxnumber = 4;



create or alter procedure factorial(@num int)
as
begin
	declare @i int=1,@fact int=1
		while(@i<=@num)
		begin 
			set @fact=@fact*@i
			set @i+=1
		end
	print 'Factorial of '+cast(@num as varchar(5))+' is:'+cast(@fact as varchar(max))
end






