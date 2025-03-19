CREATE PROCEDURE PublicationsRating AS
BEGIN
	SELECT *
	FROM
		vPublicationsRating
	ORDER BY
		NumberOfOrders DESC
END;
