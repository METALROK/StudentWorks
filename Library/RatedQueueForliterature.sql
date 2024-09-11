CREATE PROCEDURE RatedQueueForliterature @id INT
AS
BEGIN
	SELECT *
	FROM 
		QueueForLiterature(@id)
	ORDER BY
		orderDate
END;