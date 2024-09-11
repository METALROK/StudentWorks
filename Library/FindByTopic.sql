CREATE FUNCTION FindByTopic (@id INT)
RETURNS @tabl TABLE (
	PublicationID INT, 
	Title NVARCHAR(50), 
	Author NVARCHAR(50), 
	Category NVARCHAR(50),
	PublicationHouse NVARCHAR(50), 
	PublicationPlace NVARCHAR(50), 
	ReleaseDate DATE
) AS
BEGIN
	INSERT @tabl
		SELECT 
			PublicationID,
			Title,
			FirstName + ' ' + ISNULL(MiddleName, '')  + ' ' + LastName,
			Categories.Name, 
			PublicationHouses.Name,
			PublicationPlace,
			ReleaseDate
		FROM
			Literature
			LEFT JOIN Authors ON Authors.AuthorID = Literature.AuthorID
			LEFT JOIN Topics ON Topics.TopicsID = Literature.TopicID
			LEFT JOIN Categories ON Categories.CategoriesID = Literature.CategoryID
			LEFT JOIN PublicationHouses ON PublicationHouses.PublicationHouseID = Literature.PublicationHouseID
		WHERE
			TopicID = @id
	RETURN
END