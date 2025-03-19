SELECT 
	Title, 
	Literature.PublicationID, 
	COUNT(Orders.PublicationID) AS NumberOfOrders, 
	MAX(Orders.OrderDate) AS LastOrder
FROM  
	Literature 
	LEFT OUTER JOIN Orders ON Orders.PublicationID = Literature.PublicationID
GROUP BY 
	Orders.PublicationID, 
	Literature.PublicationID, 
	Literature.Title
