USE aptunes;
DELIMITER $$
CREATE PROCEDURE `GetLiedjes` (IN s VARCHAR(50))
BEGIN
	SELECT Titel FROM Liedjes WHERE Titel LIKE CONCAT('%',s,'%');
END $$
DELIMITER ;