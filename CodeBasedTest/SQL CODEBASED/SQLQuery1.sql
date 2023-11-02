create or alter proc getsalary(@empid int,@empname varchar)
as
begin
select empname from emp where empid=@empid
select salary from emp where empname =@empname
end
getsalary 4,'harsha'
select * from emp