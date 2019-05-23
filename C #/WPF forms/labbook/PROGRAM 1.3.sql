CREATE DATABASE labpractical
USE labpractical
GO



   /* PROGRAM 1.3 -1*/
--*********************

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='CUSTOMER')
DROP TABLE CUSTOMER 
GO 


CREATE TABLE CUSTOMER
(
  CUSTOMERID VARCHAR(10) CONSTRAINT PK_CUSTOMERID PRIMARY KEY NOT NULL,
  CUSTMERNAME VARCHAR(50) NOT NULL ,
  ADDRESS1 VARCHAR(300),
  ADDRESS2 VARCHAR(300),
  CONTACTNUMBER VARCHAR(82) NOT NULL ,
  POSTALCODE VARCHAR(20)
)
GO 

SP_HELP CUSTOMER 


     /*PROGRAM 1.3-2 */
--*************************


IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='EMPLOYEES')
DROP TABLE EMPLOYEES 
GO

CREATE TABLE EMPLOYEES
(
   EMPLOYEEID INT NOT NULL
   CONSTRAINT PK_CUSTOMER_EMPLOYEEID PRIMARY KEY(EMPLOYEEID),
   NAME NVARCHAR(225) NULL
)
GO 


SP_HELP EMPLOYEES


  /*PROGRAM 1.3- 3*/
--******************

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='CONTRACTORS')
DROP TABLE CONTRACTORS
GO

CREATE TABLE CONTRACTORS
(
  CONTRACTORID INT NOT NULL
   CONSTRAINT PK_CONTRACTORS_CONTRACTORID PRIMARY KEY(CONTRACTORID),
   NAME NVARCHAR(225) NULL
)
GO 


SP_HELP CONTRACTORS


  /*PROGRAM 1.3-4*/
--******************

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='TESTRETHROW')
DROP TABLE TESTRETHROW 

CREATE TABLE TESTRETHROW 
(
  ID INT 
  CONSTRAINT PK_TESTRETHROW_ID PRIMARY KEY(ID)
)
GO

SP_HELP TESTRETHROW


  /*  TASKS */
--***********
--TASK 1
CREATE TYPE REGION  FROM 
VARCHAR (15)  
GO

CREATE DEFAULT PLACE AS 'NA';   --TASK 2

EXEC sp_bindefault 'PLACE','REGION'  --TASK 3

--TASK 4

ALTER TABLE CUSTOMER ADD REGION REGION 


--TASK 5

ALTER TABLE CUSTOMER ADD GENDER CHAR(1)

--TASK 6
 
 ALTER TABLE CUSTOMER ADD CONSTRAINT CHK_CUSTOMER_GENDER CHECK(GENDER IN ('M','F','T'))

 --TASK 7

 IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='ORDERS')
 DROP TABLE ORDERS
 

 CREATE TABLE ORDERS 
 (
   ORDERSID INT NOT NULL
   CONSTRAINT CHK_ORDERS_ORDERID CHECK(ORDERSID >1000),
   CUSTOMERID VARCHAR(10) NOT NULL
   CONSTRAINT FK_ORDERS_CUSTOMERID REFERENCES CUSTOMER(CUSTOMERID),
   ORDERSDATE DATETIME,
   ORDERSTATE CHAR(1)
   CONSTRAINT CHK_ORDER_ORDERSTATE CHECK(ORDERSTATE IN('P','C'))
)

SP_HELP ORDERS


  /* CREATING AND USING SEQUENCE */
--**********************************

  /*TASK 1*/
--***********

CREATE SEQUENCE IdSequence AS INT
START WITH 10000
INCREMENT BY 1

  /*TASK 2*/
--***********

INSERT INTO Employees (EmployeeId, Name)
VALUES (NEXT VALUE FOR IdSequence, 'Shashank');
INSERT INTO Contractors (ContractorId, Name)
VALUES (NEXT VALUE FOR IdSequence, 'Aditya');
SELECT * FROM Employees;
SELECT * FROM Contractors;



  /*TASK 1.4*/
--*************

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='Desig_Master')
DROP TABLE Desig_Master
GO

CREATE TABLE Desig_Master
(
Design_code INT CONSTRAINT PK_Design_Code PRIMARY KEY NOT NULL,
Design_name VARCHAR(50)
)

INSERT INTO Desig_Master
VALUES
(1,'Professor'),
(2,'Asst Professor'),
(3,'Teacher')


IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='Department_Master')
DROP TABLE Department_Master
GO

CREATE TABLE Department_Master
(
Dept_Code INT CONSTRAINT PK_Dept_Code PRIMARY KEY NOT NULL,
Dept_name VARCHAR(50)
)

INSERT INTO Department_Master
VALUES
(10,'Chemistry'),
(20,'Physics'),
(30,'Botany'),
(40,'Mathematics'),
(50,'Computer Science')

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='Student_Master')
DROP TABLE Student_Master
GO

CREATE TABLE Student_Master
(
Student_Code INT CONSTRAINT PK_Student_Code PRIMARY KEY NOT NULL, 
Student_name VARCHAR(50)NOT NULL,
Dept_Code INT CONSTRAINT FK_Dept_Code FOREIGN KEY (Dept_Code) REFERENCES Department_Master(Dept_Code),
Student_dob DATETIME,
Student_Address VARCHAR(240)
)

INSERT INTO Student_Master
VALUES
(5,'Bharath',30,'1996/05/14','Srinagar,Jammu'),
(4,'Jithendra',30,'1982/04/04','Chennai,Tamilnadu'),
(1,'Deepak',10,'1996/04/15','Hyderabad,Telangana'),
(2,'Arun',20,'1996/04/08','Cochin,Kerala'),
(3,'Girish',10,'1997/05/09','Banglore,Karnataka')

SELECT * FROM  Student_Master

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='Student_Marks')
DROP TABLE Student_Marks
GO

CREATE TABLE Student_Marks
(
Student_Code INT CONSTRAINT FK_Student_Code FOREIGN KEY (Student_Code) REFERENCES Student_Master(Student_Code),
Student_Year INT NOT NULL,
Subject1 INT,
Subject2 INT,
Subject3 INT
)

INSERT INTO Student_Marks
VALUES
(5,2018,99,56,67),
(4,1992,88,98,77),
(1,2018,88,78,56),
(2,2018,99,58,45),
(3,2017,56,78,44)

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='Staff_Master')
DROP TABLE Staff_Master
GO

CREATE TABLE Staff_Master
(
Staff_code INT CONSTRAINT PK_Staff_code PRIMARY KEY NOT NULL,
Staff_Name VARCHAR(50) NOT NULL,
Design_code INT CONSTRAINT FK_Design_code FOREIGN KEY (Design_code) REFERENCES Desig_Master(Design_code),
Dept_code INT CONSTRAINT FK_Dept_code1 FOREIGN KEY (Dept_code) REFERENCES Department_Master(Dept_code),
HireDate DATETIME,
Staff_dob DATETIME,
Staff_address VARCHAR(240),
Mgr_code INT,
Staff_sal DECIMAL(10,2)
)

INSERT INTO Staff_Master
VALUES
(1,'Ramesh',1,10,'2018/04/06','1972/02/03','Hyderabad',3,82202),
(2,'Shiva',2,20,'2017/03/09','1986/06/08','Banglore',3,89666),
(3,'Dyanesh',1,10,'2000/05/06','1966/08/05','Chennai',1,99999),
(4,'Sanjay',3,30,'2018/06/05','1988/04/05','Hyderabad',3,20000)

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='Book_Master')
DROP TABLE Book_Master
GO

CREATE TABLE Book_Master
(
Book_Code INT NOT NULL CONSTRAINT PK_Book_Code PRIMARY KEY,
Book_Name VARCHAR(50) NOT NULL,
Book_pub_year INT,
Book_pub_author VARCHAR(50) NOT NULL,
Book_category VARCHAR(10) NOT NULL
)

INSERT INTO Book_Master
VALUES 
(4,'Journey to center',2018,'Ragahavan','Fiction'),
(3,'An Triology',2007,'Sharma','Fiction'),
(1,'Atoms and Molecules',2018,'Einstein','Science'),
(2,'Space Expedition',2010,'Neil Armstrong','Space')


IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='Book_Transaction')
DROP TABLE Book_Transaction
GO

CREATE TABLE Book_Transaction
(
Book_Code INT CONSTRAINT FK_Book_Code FOREIGN KEY (Book_Code) REFERENCES Book_Master(Book_Code),
Student_code INT NULL CONSTRAINT FK_Student_code1 FOREIGN KEY (Student_code) REFERENCES Student_Master(Student_code),
Staff_code INT NULL CONSTRAINT FK_Staff_code FOREIGN KEY (Staff_code) REFERENCES Staff_Master(Staff_code),
Book_Issue_date DATETIME NOT NULL,
Book_expected_return_date DATETIME NOT NULL,
Book_actual_return_date DATETIME NULL
)

INSERT INTO Book_Transaction
VALUES 
(3,2,3,'2019/03/23','2019/03/30','2019/03/27'),
(1,3,3,'2019/03/20','2019/03/27','2019/03/23'),
(2,2,1,'2019/02/16','2019/02/23','2019/02/20'),
(1,1,2,'2019/03/09','2019/03/16','2019/03/15')


--TASK 1.4 QUERIES
--*****************

SELECT Student_Code,Student_Name,Dept_Code FROM Student_Master

SELECT Staff_Code,Staff_Name,Dept_Code FROM Staff_Master

SELECT Staff_Name, Staff_Sal,Dept_Code from Staff_Master WHERE Dept_Code=20 or Dept_Code=30 or Dept_Code=40

SELECT Student_Code,Subject1,Subject2,Subject3 ,(Subject1+Subject2+Subject3) AS Total_Marks FROM Student_Marks

SELECT Book_Name FROM Book_Master WHERE Book_Name LIKE 'An%'

SELECT Dept_Code FROM Student_Master WHERE Student_Code in( SELECT Student_Code FROM Student_Marks WHERE Student_Year=2018)

SELECT Staff_Code 'StaffCode',Staff_Name'StaffName',Dept_Code'Dept Code',HireDate'Date of Joining',(2019-YEAR(HireDate)) AS No_of_Years FROM Staff_Master

SELECT Staff_Name FROM Staff_Master WHERE YEAR(HireDate)<2010

SELECT Student_Name,Dept_Code,Student_dob FROM Student_Master WHERE (Student_dob BETWEEN '1981/01/01' AND '1983/03/31') 

SELECT Student_Code FROM Student_Marks WHERE Subject2=0 

--CASE STUDY
--***********

CREATE TABLE Products
(
ProductID INT PRIMARY KEY,
ProductName VARCHAR(100),
Rate MONEY
)
--Insert records into target table
INSERT INTO Products
VALUES
(1,'Tea', 10.00),
(2, 'Coffee', 20.00),
(3, 'Muffin', 30.00),
(4, 'Biscuit', 40.00)


CREATE TABLE UpdatedProducts
(
ProductID INT PRIMARY KEY,
ProductName VARCHAR(100),
Rate MONEY
)
--Insert records into source table
INSERT INTO UpdatedProducts
VALUES
(1, 'Tea', 10.00),
(2, 'Coffee', 25.00),
(3, 'Muffin', 35.00),
(5, 'Pizza', 60.00)


--Synchronize the target table with
--refreshed data from source table
MERGE Products AS TARGET
USING UpdatedProducts AS SOURCE
ON (TARGET.ProductID = SOURCE.ProductID)
--When records are matched, update
--the records if there is any change
WHEN MATCHED AND TARGET.ProductName <> SOURCE.ProductName
OR TARGET.Rate <> SOURCE.Rate THEN
UPDATE SET TARGET.ProductName = SOURCE.ProductName,
TARGET.Rate = SOURCE.Rate
--When no records are matched, insert
--the incoming records from source
--table to target table
WHEN NOT MATCHED BY TARGET THEN
INSERT (ProductID, ProductName, Rate)
VALUES (SOURCE.ProductID, SOURCE.ProductName, SOURCE.Rate)
--When there is a row that exists in target table and
--same record does not exist in source table
--then delete this record from target table
WHEN NOT MATCHED BY SOURCE THEN
DELETE
--$action specifies a column of type nvarchar(10)
--in the OUTPUT clause that returns one of three
--values for each row: 'INSERT', 'UPDATE', or 'DELETE',
--according to the action that was performed on that row
OUTPUT $action,
DELETED.ProductID AS TargetProductID,
DELETED.ProductName AS TargetProductName,
DELETED.Rate AS TargetRate,
INSERTED.ProductID AS SourceProductID,
INSERTED.ProductName AS SourceProductName,
INSERTED.Rate AS SourceRate;
SELECT @@ROWCOUNT;
GO


--CASE STUDY
--***********

CREATE TABLE Employee
(
Employee_Number INT NOT NULL PRIMARY
KEY,
Employee_Name VARCHAR(30) NULL,
Salary FLOAT NULL,
Department_Number INT NULL,
Region VARCHAR(30) NULL
)

INSERT INTO Employee
VALUES
(1,'Arun',88324,10,'Kerala'),
(2,'Deepak',83334,20,'Hyderabad'),
(3,'Bharath',85898,10,'Coimbatore')


SELECT Region, Department_Number, AVG (Salary)
Average_Salary
From Employee
Group BY GROUPING SETS
( (Region, Department_Number),
(Region),
(Department_Number)
)

SELECT Region, Department_Number, AVG (Salary) Average_Salary
From Employee
Group BY (Region)
UNION
SELECT Region, Department_Number, AVG (Salary) Average_Salary
From Employee
Group BY (Department_Number)

--TASK 1.5- JOINS,SUBQUERIES 
--***************************

SELECT Staff_Master.Staff_Name, Staff_Master.Dept_Code, Department_Master.Dept_name
FROM Staff_Master
INNER JOIN Department_Master ON Staff_Master.Dept_Code=Department_Master.Dept_Code

SELECT Staff_Master.Staff_Name, Staff_Master.Dept_Code, Department_Master.Dept_name
FROM Staff_Master
INNER JOIN Department_Master ON Staff_Master.Dept_Code=Department_Master.Dept_Code
WHERE Staff_Master.Dept_code!=10

SELECT Book_Master.Book_Name, COUNT(*) AS Times_Issued
FROM Book_Master
RIGHT JOIN Book_Transaction ON Book_Master.Book_Code = Book_Transaction.Book_Code
GROUP BY Book_Master.Book_Name

SELECT Department_Master.Dept_name,COUNT(*) AS Total_Students
FROM Department_Master
RIGHT JOIN Student_Master ON Department_Master.Dept_Code=Student_Master.Dept_Code
GROUP BY Department_Master.Dept_name


SELECT a.Staff_Code Staff_Code,a.Staff_Name Staff_Name,
		b.Mgr_code Manager_Code,b.Staff_Name Manager_Name
FROM Staff_Master a JOIN Staff_Master b
		ON a.Mgr_code=b.Staff_code

SELECT Staff_Code,Staff_Name,HireDate,DATENAME(WEEKDAY,HireDate) AS DAY FROM Staff_Master 
ORDER BY DAY

SELECT Staff_Master.Staff_Name,COUNT(*) AS Total
FROM Staff_Master
RIGHT JOIN Book_Transaction ON Staff_Master.Staff_code=Book_Transaction.Staff_code
GROUP BY Staff_Master.Staff_Name

SELECT Student_Name FROM Student_Master WHERE Student_Code IN ( SELECT Student_Code FROM Student_Marks WHERE Subject1=99)

SELECT Book_Name,Book_pub_author,Book_Code FROM Book_Master
WHERE NOT EXISTS (SELECT Book_Code FROM Book_Transaction WHERE Book_Master.Book_Code=Book_Transaction.Book_Code )

SELECT Staff_Code Code, Staff_Name Name FROM Staff_Master
UNION ALL
SELECT Student_Code ,Student_Name  FROM Student_Master
WHERE Dept_Code=20

SELECT Student_Code FROM Student_Master
WHERE NOT EXISTS (SELECT Student_Code FROM Book_Transaction WHERE Student_Master.Student_Code=Book_Transaction.Student_code)


--INSERTING VALUES INTO CUSTOMER TABLE 
--************************************

INSERT INTO CUSTOMER
VALUES
('ALFKI','AlfredsFutterkiste','Obere Str. 57','Berlin,Germany','030-0074321','12209',NULL,NULL),
('ANATR','Ana Trujillo Emparedados y helados','Avda. dela Constitución 2222','México D.F.,Mexico','(5) 555-4729','5021','NA',NULL),
('ANTON','Antonio Moreno Taquería','Mataderos 2312','México D.F.,Mexico','(5) 555-3932','5023',NULL,NULL),
('AROUT','Around the Horn','120 Hanover Sq.','London UK','(171)555-7788','WA11DP',NULL,NULL),
('BERGS','Berglundssnabbköp','Berguvsvägen 8','Luleå,Sweden','0921-1234 65','S-95822',NULL,NULL),
('BLAUS','Blauer See Delikatessen','Forsterstr. 57','Mannheim,Germany','0621-08460','68306','NA',NULL),
('BLONP','Blondesddslpèreet fils','24, placeKléber','Strasbourg,France','88.60.15.31','67000',NULL,NULL),
('BOLID','BólidoComidaspreparadas','C/Araquil,67','Madrid,Spain','(91) 55522 82','28023','EU',NULL),
('BONAP','Bon app','12, ruedes Bouchers','Marseille,France','91.24.45.40','13008',NULL,NULL),
('BOTTM','Bottom-Dollar Markets','23Tsawassen Blvd.','Tsawassen,Canada','(604)555-4729','T2F8M4','BC',NULL)

SELECT * FROM CUSTOMER

SP_HELP CUSTOMER

UPDATE CUSTOMER SET CONTACTNUMBER='(604) 3332345' WHERE CUSTOMERID='ANATR'

UPDATE CUSTOMER SET ADDRESS1='19/2 12th Block, Spring Fields.',ADDRESS2='Ireland - UK' WHERE CUSTOMERID='BOTTM'

--INSERTING VALUES INTO ORDER TABLE
--**********************************

CREATE SEQUENCE IdOrders1 AS INT
START WITH 1001
INCREMENT BY 1

INSERT INTO ORDERS
VALUES
(NEXT VALUE FOR IdOrders1,'AROUT','4-Jul-96','P'),
(NEXT VALUE FOR IdOrders1,'ALFKI','5-Jul-96','C'),
(NEXT VALUE FOR IdOrders1,'BLONP','8-Jul-96','P'),
(NEXT VALUE FOR IdOrders1,'ANTON','8-Jul-96','P'),
(NEXT VALUE FOR IdOrders1,'ANTON','9-Jul-96','P'),
(NEXT VALUE FOR IdOrders1,'BOTTM','10-Jul-96','C'),
(NEXT VALUE FOR IdOrders1,'BONAP','11-Jul-96','P'),
(NEXT VALUE FOR IdOrders1,'ANATR','12-Jul-96','P'),
(NEXT VALUE FOR IdOrders1,'BLAUS','15-Jul-96','C')


SELECT * FROM ORDERS

DELETE FROM CUSTOMER FROM CUSTOMER RIGHT OUTER JOIN ORDERS ON CUSTOMER.CUSTOMERID=ORDERS.CUSTOMERID


UPDATE ORDERS SET ORDERSTATE='C' WHERE ORDERSDATE<15/06/96

--TASK 1.6 INDEXES
--*****************

CREATE UNIQUE NONCLUSTERED INDEX idx_DepartmentName_notnull
ON Department_Master(Dept_Name)
WHERE Dept_Name IS NOT NULL;

INSERT INTO Department_Master
VALUES
(100,'Home Science'),
(200,'Home Science'),
(300,NULL),
(400,NULL)

CREATE NONCLUSTERED INDEX idx_Code_Code_notnull
ON Book_Transaction(Book_Code)

CREATE NONCLUSTERED INDEX idx_Staff_Name_notnull
ON Staff_Master(Staff_Name)

CREATE NONCLUSTERED INDEX idx_Department_Name_notnull
ON Department_Master(Dept_Name)

CREATE NONCLUSTERED INDEX idx_Date_of_issue_notnull
ON Book_Transaction(Book_Issue_date)


CREATE VIEW Staff_Details AS
SELECT Staff_Code,Staff_Name,Dept_Name,Design_Name,Staff_sal
FROM Staff_Master,Department_Master,Desig_Master
where Staff_Master.Staff_code>1;

--TASK 1.7 PROCEDURES
--********************
CREATE TABLE STAFF_MASTERS_BACK AS (SELECT * FROM Staff_Master);
TRUNCATE TABLE STAFF_MASTERS_BACK;

CREATE PROCEDURE staff_backup


--WORKING WITH EXCEPTIONS 
--************************

--TASK1
--******

BEGIN TRY
INSERT dbo.TestRethrow(ID) VALUES(1);
-- Force error 2627, Violation of PRIMARY KEY constraint to be raised.
INSERT dbo.TestRethrow(ID) VALUES(1);
END TRY
BEGIN CATCH
PRINT 'In catch block.';
END CATCH;

--TASK 3
--******
BEGIN TRY
INSERT dbo.TestRethrow(ID) VALUES(1);
-- Force error 2627, Violation of PRIMARY KEY constraint to be raised.
INSERT dbo.TestRethrow(ID) VALUES(1);
END TRY
BEGIN CATCH
PRINT 'In catch block.';
THROW;
END CATCH;



--LAB 2
--******

SELECT Staff_Code,Staff_Name,Dept_Code FROM Staff_Master WHERE (2019-YEAR(HireDate)>18)

SELECT Staff_Name,Staff_Sal,REPLACE(Staff_sal,FLOOR(Staff_sal%10),'X') 
'SALARY($)' FROM Staff_Master 

SELECT Book_Code,Student_Code FROM Book_Transaction WHERE Book_expected_return_date>GETDATE()

SELECT Staff_Name FROM Staff_Master WHERE MONTH(Staff_dob)=MONTH(GETDATE())

SELECT COUNT(*) FROM Book_Transaction WHERE Book_expected_return_date=GETDATE()

SELECT ROUND(MAX(Staff_Sal),1) 'Maximum',ROUND(MIN(Staff_Sal),1)'Minimum',ROUND(AVG(Staff_Sal),1)'Average' FROM Staff_Master

SELECT COUNT(*),a.Staff_Code Staff_Code,a.Staff_Name Staff_Name,
		b.Mgr_code Manager_Code,b.Staff_Name Manager_Name
FROM Staff_Master a JOIN Staff_Master b
		ON a.Mgr_code=b.Staff_code

SELECT Student_Code, COUNT(*) FROM Student_Marks WHERE Subject1>60 AND Subject2>60 AND Subject3>60

SELECT COUNT(*) AS total FROM
(
    SELECT Student_Code
    FROM Student_Marks
    WHERE Subject1>60 AND Subject2>60 AND Subject3>60
    GROUP BY Student_Year
    HAVING COUNT(DISTINCT Student_Year)<2019
)

--JOINS AND SUBQUERIES
--*********************

CREATE TABLE Salary_Grade
(
	LoSal INT,
	HiSal INT,
	Grade CHAR
)

INSERT INTO Salary_Grade
VALUES
(50000,100000,'A'),
(25000,50000,'B'),
(10000,25000,'C')

SELECT Staff_Master.Staff_sal,Staff_Master.Staff_Name,Salary_Grade.Grade
FROM Staff_Master
LEFT JOIN Salary_Grade 
ON Staff_Master.Staff_sal BETWEEN Salary_Grade.LoSal AND Salary_Grade.HiSal



CREATE TABLE Student_Grade
(
	Grade CHAR,
	HiMar INT,
	LoMar INT
)
INSERT INTO Student_Grade
VALUES
('A',80,70),
('B',69,60),
('E',100,80),
('F',60,0)

ALTER TABLE Student_Marks ADD Total_Percent AS (Subject1+Subject2+Subject3)/3

SELECT Student_Marks.Student_Code,(Subject1+Subject2+Subject3)/3 AS Total_Percent,Student_Grade.Grade
FROM Student_Marks
LEFT JOIN Student_Grade 
ON Student_Marks.Total_Percent BETWEEN Student_Grade.LoMar AND Student_Grade.HiMar



