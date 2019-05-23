CREATE TABLE Supplier
(
	SupplierId INT PRIMARY KEY,
	Suppliername VARCHAR(30),
	City VARCHAR(30),
	ContactNo varchar(10)constraint CK_MyTable_ContactNo check (ContactNo like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	CreditBalance INT
)

SELECT * FROM Supplier
