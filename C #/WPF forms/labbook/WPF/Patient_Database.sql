IF EXISTS(SELECT * FROM SYSOBJECTS WHERE Name='PatientDetail') 
DROP TABLE PatientDetail 
GO

CREATE TABLE PatientDetail
(
     PatientID int PRIMARY KEY,
     PatientName varchar(30),
     PatientType varchar(30)
)

Select * from PatientDetail