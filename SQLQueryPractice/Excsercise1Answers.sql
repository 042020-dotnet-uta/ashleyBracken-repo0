// Ash Answers

-- 1. list all customers (full names, customer ID, and country) who are not in the US
Select CustomerId, FirstName, LastName, Country
From Customer
Where Country != 'USA'
-- 2. list all customers from brazil
Select *
From Customer
Where Country = 'Brazil'

-- 3. list all sales agents
Select *
From Employee
Where Title Like '%sales% agent%'

-- 4. show a list of all countries in billing addresses on invoices.
Select BillingCountry
From Invoice
Group By BillingCountry

-- 5. how many invoices were there in 2009, and what was the sales total for that year?
Select Count(InvoiceID),SUM(Total)
From Invoice
Where InvoiceDate Like '%2009%'
-- 6. how many line items were there for invoice #37?
Select Count(InvoiceLineId) as AmountOfLineItems
From InvoiceLine 
Where InvoiceId = '37'
-- 7. how many invoices per country?
Select BillingCountry,COUNT(InvoiceId) as TotalInvoices
From Invoice
Group By BillingCountry 

-- 8. show total sales per country, ordered by highest sales first.
Select BillingCountry,Sum(Total) as TotalSales
From Invoice
Group By BillingCountry
Order By Sum(Total) desc

