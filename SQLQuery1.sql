--Create Table Category
--(
--CategpryId int primary key identity(1,1),
--CategoryName Nvarchar(50),
--CategoryStatus bit
--)
--Create Table Product(
--Id int primary key identity(1,1),
--Title Nvarchar(100),
--Price decimal(10,2),
--CoverImage Nvarchar(250),
--City Nvarchar(100),
--District Nvarchar(100),
--Address Nvarchar(500),
--Description Nvarchar(Max),
--CategoryId int
--)
--Create Table ProductDetail
--(
--Id int primary key identity(1,1),
--Size int,
--ProductId int,
--Price int,
--Location Nvarchar,
--VideoUrl Nvarchar,
--Amount int
--)

--Create Table Client (
--Id int primary key identity(1,1),
--Name Nvarchar(150),
--Title Nvarchar(100),
--Comment Nvarchar(2000)
--)
Create Table Employee(
Id int primary key identity(1,1),
Name Nvarchar(150),
Title Nvarchar(100),
Mail Nvarchar(100),
PhoneNumber Nvarchar(100),
ImageUrl Nvarchar(100),
ProfilPhotoUrl Nvarchar(100),
Status bit
)