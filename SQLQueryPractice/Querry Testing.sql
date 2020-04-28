/*
Use EmployeeExample

insert into Employee (EmployeeID,FirstName,LastName,SSN,DeptID)
Values('1','Tina','Smith','123','1')

insert into Employee (EmployeeID,FirstName,LastName,SSN,DeptID)
Values('2','Leila','Turner','789987','2')

insert into Employee (EmployeeID,FirstName,LastName,SSN,DeptID)
Values('3','Amber','Jack','456654','3')
*/
--insert into Employee (EmployeeID,FirstName,LastName,SSN,DeptID)
--Values('4','Sheila','Tony','123321','1')

Select *
From Employee
/*
Alter Table EmployeeDetails
Alter Column City Varchar(255)
Alter Table EmployeeDetails
Alter Column State varchar (255)
Alter Table EmployeeDetails
*/
/*
Use EmployeeExample
Insert into EmployeeDetails(EmployeeID,Salary,AddressOne,AddressTwo,City,State,Country,DetailsID)
Values ('1','500','213','321','Howling Creek','South Carolina','USA','1')
Insert into EmployeeDetails(EmployeeID,Salary,AddressOne,AddressTwo,City,State,Country,DetailsID)
Values ('2','566','654','754','Shadows Way','SomeCity','Russia','2')
Insert into EmployeeDetails(EmployeeID,Salary,AddressOne,AddressTwo,City,State,Country,DetailsID)
Values ('3','456','654','002','Sunny Rd','South Carolina','Germany','3')
*/

Select*
From EmployeeDetails

Select *
From Department

Select FirstName,LastName
From Employee
Where DeptID = 1;
use EmployeeExample
Select SUM(Salary),Employee.DeptID
From EmployeeDetails,Employee
Where Employee.DeptID = 1

