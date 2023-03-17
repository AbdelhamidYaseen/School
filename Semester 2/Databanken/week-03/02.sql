USE aptunes;
DELIMITER $$
CREATE DEFINER=`root`@`%` PROCEDURE `NumberOfGenres`(OUT total tinyInt)
BEGIN
	SELECT COUNT(Distinct Id) INTO total FROM Genres;
END $$
DELIMITER ;