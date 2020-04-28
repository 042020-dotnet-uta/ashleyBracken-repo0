Create Table [dbo].[Empoloyee]
 (
 [EmployeeID] int not Null,
 [FirstName] varchar not null,
 [LastName] varchar not null,
 [DeptID] int not null,
 Primary Key (EmployeeID),
 );

 Create Table [dbo].[Department]
 (
 [DeptID] int not null,
 [DeptName] Varchar not null,
 [Location] varchar not null,
 )

 Create Table [dbo].[EmployeeDetails]
 (
 [EmployeeID] int not Null,
 [Salary] int not Null,
 [AddressOne] int not null,
 [AddressTwo] int,
 [City] varchar not null,
 [State] varchar not null,
 [Country] varchar not null
 )