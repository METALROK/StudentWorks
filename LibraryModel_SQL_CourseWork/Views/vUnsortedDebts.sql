SELECT 
	FirstName + ' ' + ISNULL(MiddleName, '') + LastName AS Name, 
	MAX(YEAR(OrderDate)) AS Year
FROM   
	Orders 
	LEFT OUTER JOIN Customers ON Customers.CustomerID = Orders.CustomerID
WHERE 
	OrderStatus = 'OVERDUE'
GROUP BY 
	OrderDate, 
	FirstName + ' ' + ISNULL(MiddleName, N'') + LastName
