USE aptunes;
DELIMITER $$
CREATE DEFINER=`root`@`%` PROCEDURE `CreateAndReleaseAlbum`(IN titel VARCHAR(100), IN bands_Id INT)
BEGIN

INSERT INTO Albums (Titel)
VALUES (titel);

INSERT INTO Albumreleases (Bands_Id, Albums_Id)
VALUES (bands_Id, LAST_INSERT_ID());

END$$
DELIMITER ;
