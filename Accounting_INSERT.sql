CREATE TRIGGER Accounting_INSERT
ON Orders
AFTER INSERT
AS
BEGIN
	DECLARE @id INT, @customer INT
	DECLARE iter CURSOR LOCAL FAST_FORWARD FOR
	SELECT OrderID, CustomerID FROM inserted
	OPEN iter 
		WHILE (1 = 1)
		BEGIN
			FETCH iter INTO @id, @customer
			IF @@FETCH_STATUS <> 0
				BREAK
			IF @customer IN (SELECT CustomerID FROM Customers)
				UPDATE Customers SET CurrentOrderStatus = 'ACTIVE' WHERE CustomerID = @customer
			ELSE
				BEGIN
					PRINT 'Add the customer, please'
					DELETE Orders WHERE OrderID = @id 
				END
		END
	CLOSE iter;
	DEALLOCATE iter; 
END