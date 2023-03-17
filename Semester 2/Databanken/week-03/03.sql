USE aptunes;
DELIMITER $$ ;
CREATE PROCEDURE `CleanupOldMemberships` (IN someDate DATE, OUT numberCleaned INT)
BEGIN
	SELECT COUNT(*) FROM Lidmaatschappen WHERE Einddatum < someDate into numberCleaned;
    SET SQL_SAFE_UPDATES = 0;
    DELETE FROM Lidmaatschappen WHERE Einddatum < someDate;
    SET SQL_SAFE_UPDATES = 1;
END $$
DELIMITER ;