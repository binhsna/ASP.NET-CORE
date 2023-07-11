use master;
go
IF DB_ID('firstNetCoreProject') IS NOT NULL
	DROP DATABASE firstNetCoreProject
go
create database firstNetCoreProject;
go
use firstNetCoreProject
go
create table Users(
	Id int identity(1,1),
	Name nvarchar(50),
	Email nvarchar(150),
	Phone nvarchar(15),
	Address nvarchar(250),
	constraint pk_Users primary key(Id)
);
go
create table Products(
	id int identity(1,1),
	name nvarchar(50),
	price float,
	quantity int,
	constraint pk_Products primary key(id)
);
go
SET IDENTITY_INSERT Users ON 
insert into Users(Id, Name, Email, Phone, Address)values
(1, N'Nguyễn Công Bình',N'binhsna@gmail.com',N'0971912776',N'TP Hà Nội'),
(2, N'Nguyễn Văn Nam',N'nambb@gmail.com',N'0371912776',N'TP HCM'),
(3, N'Bùi Thị Hạnh',N'hanhbt@gmail.com',N'0981312776',N'TP Hà Nội');
SET IDENTITY_INSERT Users OFF 
go
SET IDENTITY_INSERT Products ON 
insert into Products(id, name, price, quantity)values
(1, N'Laptop', 1000,200),
(2, N'Iphone', 1200,200),
(3, N'Macbook', 1500,200);
SET IDENTITY_INSERT Products OFF 
go