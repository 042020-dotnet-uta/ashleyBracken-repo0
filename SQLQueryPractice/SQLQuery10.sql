
--use Database(EmplyeeDBExcercise);
Create Table [dbo].[Empoloyee]
 (
 [EmployeeID] int not Null,
 [FirstName] varchar not null,
 [LastName] varchar not null,
 [DeptID] int not null,
 Primary Key (EmployeeID),
 --Foreign Key (DeptID) references Department(DeptID)
 );
