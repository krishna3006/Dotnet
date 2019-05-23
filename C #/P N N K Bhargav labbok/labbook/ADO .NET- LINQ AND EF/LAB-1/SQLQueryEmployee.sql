create table employee
( empno int primary key,
 empname varchar(50) not null,
 empsal numeric(10,2) check(empsal >= 25000) ,
 emptype varchar(1) check(emptype in('C','P'))
)
go
create proc GetEmployeeById
(
@eno int
)
as
select * from employee where empno = @eno
goselect * from employee--Procedure to Delete record CREATE PROC prcEmployeeDelete
					@empno INT,@RES INT OUTPUT
AS
BEGIN
    IF EXISTS(SELECT * FROM employee WHERE empno=@empno)
	BEGIN
	SET @RES=1
	DELETE FROM employee WHERE empno=@empno
	END
	ELSE 
	BEGIN
	SET @RES=0 
	END
END


CREATE PROC prcEmployeeauto 				
AS
BEGIN
	SELECT MAX(empno)+1 FROM employee 
END


CREATE PROC prcEmployeeInsert 
					@empno INT,
					@empname VARCHAR(50),
					@empsal numeric(10,2),
					@emptype varchar(1)				
AS
BEGIN  
	INSERT INTO employee VALUES(@empno,@empname,@empsal,@emptype)
END


