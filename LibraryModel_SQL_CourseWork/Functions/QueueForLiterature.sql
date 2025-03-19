CREATE FUNCTION QueueForLiterature (@literatureID INT)
RETURNS @tabl TABLE (id INT, name NVARCHAR(50), orderDate DATE)
AS
BEGIN
	INSERT @tabl
		SELECT 
			Orders.CustomerID,
			FirstName + ' ' + LastName,
			OrderDate
		FROM
			Orders 
			LEFT JOIN Customers ON Customers.CustomerID = Orders.CustomerID
		WHERE
			PublicationID = @literatureID AND
			OrderStatus = 'ACTIVE'
	RETURN
END 
