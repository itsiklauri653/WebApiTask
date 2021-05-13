CREATE DATABASE PhysicalCustomerDB

CREATE TABLE [PhysicalCustomerDB].[dbo].[Cities] (
    [Id] int primary key identity(1,1),
    [Name] nvarchar(50),
    [Status] int not null,
);

CREATE TABLE [PhysicalCustomerDB].[dbo].[Customers] (
    [Id] int primary key identity(1,1),
    [FirstName] nvarchar(50) not null,
	[LastName] nvarchar(50) not null,
	[Gender] int,
	[PersonalId] nvarchar(11) not null,
	[BirthDate] datetime2(7) not null,
	[CityId] int foreign key references [PhysicalCustomerDB].[dbo].[Cities](Id) not null,
	[GraphicalData] nvarchar(max),
    [Status] int not null,
);

CREATE TABLE [PhysicalCustomerDB].[dbo].[Phones] (
    [Id] int primary key identity(1,1),
    [Type] int not null,
	[CustomerId] int foreign key references [PhysicalCustomerDB].[dbo].[Customers](Id) not null,
	[Number] nvarchar(50) not null,
    [Status] int not null,
);

CREATE TABLE [PhysicalCustomerDB].[dbo].[ConnectedCustomers] (
    [Id] int primary key identity(1,1),
    [ConnectionType] int not null,
	[CustomerFromId] int foreign key references [PhysicalCustomerDB].[dbo].[Customers](Id) not null,
	[CustomerToId] int foreign key references [PhysicalCustomerDB].[dbo].[Customers](Id) not null,
    [Status] int not null,
);

INSERT INTO [PhysicalCustomerDB].[dbo].[Cities]
VALUES ('Tbilisi',0);

INSERT INTO [PhysicalCustomerDB].[dbo].[Cities]
VALUES ('Batumi',0);

INSERT INTO [PhysicalCustomerDB].[dbo].[Cities]
VALUES ('Moscow',0);

INSERT INTO [PhysicalCustomerDB].[dbo].[Cities]
VALUES ('London',0);

INSERT INTO [PhysicalCustomerDB].[dbo].[Cities]
VALUES ('Paris',0);

INSERT INTO [PhysicalCustomerDB].[dbo].[Cities]
VALUES ('Tokyo',0);