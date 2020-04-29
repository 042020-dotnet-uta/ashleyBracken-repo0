--Alter table State
--Add Foreign Key (CountryID) references Country

Select*
From State;
Select*
From Country;

Use StateCountry
--Insert Into Country (CountryID,CountryName)
--Values ('1','Canada')
/*
Use StateCountry
Insert Into Country (CountryID,CountryName)
Values ('2','Germany')
Use StateCountry
Insert Into Country (CountryID,CountryName)
Values ('3','Japan')
Use StateCountry
Insert Into Country (CountryID,CountryName)
Values ('4','USA')
Use StateCountry
Insert Into Country (CountryID,CountryName)
Values ('5','England')
Use StateCountry
Insert Into Country (CountryID,CountryName)
Values ('6','Russia')
use StateCountry
Insert Into State(StateID,CountryID,StateName)
values('1','4','SouthCarolina')
Insert Into State(StateID,CountryID,StateName)
values('2','3','Denile')
Insert Into State(StateID,CountryID,StateName)
values('3','5','London')
Insert Into State(StateID,CountryID,StateName)
values('4','1','Ottawa')
Insert Into State(StateID,CountryID,StateName)
values('5','6','Rasputin')
*/
Use StateCountry
Select *
From State
Join Country on Country.CountryID = State.CountryID