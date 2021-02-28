use master
Create Database AdoProjectAsraful
Go

use AdoProjectAsraful
go

Create Table Authors
(
AuthorID int Primary key Identity,
AuthorName varchar(30),
Gender varchar(20),
Email varchar(30),
Phone varchar(20),
Address varchar(50),
Image varchar(200)
)
Go

Create Table Books
(
BookID int Primary Key Identity,
BookName varchar(30),
BookPrice varchar(20),
Edition varchar(20),
Publication varchar(30),
BookAuthorID int Foreign key References Authors(AuthorID)
)
Go

Select * From Authors
Select * From Books