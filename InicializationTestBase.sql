CREATE DATABASE TestBase
GO
USE TestBase
CREATE TABLE Category
(
	CategoryId int PRIMARY KEY IDENTITY(1,1),
	CategoryName nvarchar(50) not null
)
CREATE TABLE Product
(
	ProductId int PRIMARY KEY IDENTITY (1,1),
	ProductName nvarchar (50) not null
)
CREATE TABLE CategoryProduct
(
	CategoryId int FOREIGN KEY REFERENCES Category(CategoryId) ON DELETE CASCADE,
	ProductId int FOREIGN KEY REFERENCES Product(ProductId) ON DELETE CASCADE,
	PRIMARY KEY (CategoryId, ProductId)
)

INSERT INTO Category (CategoryName) VALUES
('�����'),
('����������� ����������')

INSERT INTO Product (ProductName) VALUES
('������ ������. ������� ���'),
('������� ������'),
('��������� ������')

INSERT INTO CategoryProduct (CategoryId, ProductId) VALUES
	(1, 1),
	(2, 1),
	(1, 2)