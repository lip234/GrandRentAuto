-- CMPT 291 Spring 2021 
-- Assignment 3 
-- Group 3 use GrantRentAuto

create table Branches
(
	BranchID int
		constraint PK_Branches
			primary key,
	City varchar(80) not null,
	Province varchar(80),
	Address varchar(80)
)
go

create table CarTypes
(
	TypeID int
		constraint PK_CarTypes
			primary key,
	Description varchar(200),
	RateDaily decimal(19,4) not null,
	RateWeekly decimal(19,4) not null,
	RateMonthly decimal(19,4) not null
)
go

create table Cars
(
	CarID int
		constraint PK_Cars
			primary key,
	PlateNumber varchar(50) not null,
	Type int not null
		constraint Cars_CarTypes_TypeID_fk
			references CarTypes,
	StoredBranch int not null,
	Status int not null
)
go

create table Customers
(
	CustomerID int
		constraint PK_Customers
			primary key,
	FullName varchar(80) not null,
	TimesRented varchar(80) not null,
	status int constraint DF_Customers_status default 0 not null,
	City varchar(50) not null,
	Province varchar(50) not null,
	Address varchar(80) not null
)
go

create table Employees
(
	EmployeeID int
		constraint PK_Employees
			primary key,
	FullName varchar(80) not null,
	Salary int,
	City varchar(80) not null,
	Province varchar(50) not null,
	WorksAt int not null
		constraint Employees_Branches_BranchID_fk
			references Branches
)
go

create table Transactions
(
	TxID int
		constraint PK_Transactions
			primary key,
	CustomerID int not null
		constraint Transactions_Customers_CustomerID_fk
			references Customers,
	CarID int not null
		constraint Transactions_Cars_CarID_fk
			references Cars,
	StartDate datetime not null,
	ReturnDate datetime not null,
	ActualReturnDate datetime not null,
	PickUpBranch int not null
		constraint Transactions_Branches_BranchPickUp_fk_2
			references Branches,
	ReturnBranch int not null
		constraint Transactions_Branches_BranchReturn_fk
			references Branches
)
go

