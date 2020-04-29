Use StateCountry
Select *
From State
Join Country on Country.CountryID = State.CountryID;

Select *
From State
Cross Join Country;

Select *
From State
Left Join Country on Country.CountryID = State.StateId;

Select *
From State
Right Join Country on Country.CountryID = State.StateId;

