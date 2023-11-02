CREATE TABLE Code_Employes (
    empno INT  PRIMARY KEY,
    empname VARCHAR(35) NOT NULL,
    empsal NUMERIC(10, 2) CHECK (empsal >= 25000),
    emptype CHAR(1) CHECK (emptype IN ('F', 'P'))
);
SELECT * FROM Code_Employes

CREATE PROCEDURE AddEmployes (
    @empname VARCHAR(35),
    @empsal NUMERIC(10, 2),
    @emptype CHAR(1)
)
AS
BEGIN
DECLARE @new_empno int;
SELECT @new_empno = COALESCE(MAX(empno), 0) + 1 FROM Code_Employes;
INSERT INTO Code_Employes(empno, empname, empsal, emptype)
    VALUES (@new_empno, @empname, @empsal, @emptype);
END;

EXEC AddEmployes @empname = 'Ashok', @empsal = 30000.00, @emptype = 'F';





DECLARE @empno INT;
DECLARE @empsal NUMERIC(10, 2);
DECLARE employee_cursor CURSOR FOR
SELECT empno, salary
FROM employeess
WHERE job = 'developer';
DECLARE @new_salary NUMERIC(10, 2);
OPEN employee_cursor;
FETCH NEXT FROM employee_cursor INTO @empno, @empsal;
WHILE @@FETCH_STATUS = 0
BEGIN  
    SET @new_salary = @empsal * 1.15; 
    UPDATE employeess
    SET salary = @new_salary
    WHERE empno = @empno; 
    FETCH NEXT FROM employee_cursor INTO @empno, @empsal;
END;
CLOSE employee_cursor;
DEALLOCATE employee_cursor;

SELECT empno,  salary
FROM employeess
WHERE job = 'developer';






   



select * from employeess