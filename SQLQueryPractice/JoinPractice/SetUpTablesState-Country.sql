Create table State
(
[StateId] int not null,
[CountryID] int not null,
[StateName] varchar(255),
Primary Key (StateID),
)

Create Table Country
(
[CountryID] int not null,
[CountryName] varchar(255) not null,
Primary Key (CountryID)
)