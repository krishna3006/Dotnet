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


CREATE PROC prcAddPAtient
@id INT,
@name VARCHAR(20),
@type VARCHAR(20)
AS
 INSERT INTO PatientDetail VALUES(@id,@name,@type)

 
CREATE PROC [dbo].[prcGetAllPatient]
AS
BEGIN
SELECT * FROM PatientDetail
END
GO