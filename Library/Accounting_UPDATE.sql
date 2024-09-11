CREATE TRIGGER Accounting_UPDATE
ON Orders
AFTER UPDATE
AS
BEGIN
	DECLARE @id INT, @status NVARCHAR(50)
	DECLARE iter CURSOR LOCAL FAST_FORWARD FOR
	SELECT CustomerID, OrderStatus FROM inserted 
	OPEN iter
		WHILE (1 = 1)
		BEGIN
			FETCH iter INTO @id, @status
			IF @@FETCH_STATUS <> 0
				BREAK
			IF @status = 'CLOSED' AND NOT EXISTS(SELECT OrderStatus FROM Orders WHERE OrderStatus = 'ACTIVE' AND CustomerID = @id)
				UPDATE Customers SET CurrentOrderStatus = NULL WHERE CustomerID = @id
			IF @status = 'OVERDUE' 
				UPDATE Customers SET CurrentOrderStatus = 'DEBT' WHERE CustomerID = @id
		END;
END