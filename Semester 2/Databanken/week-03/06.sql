USE aptunes;
DELIMITER $$
CREATE DEFINER=`root`@`%` PROCEDURE `MockAlbumreleaseWithSuccess`(OUT success BOOL)
BEGIN
	DECLARE randomAlbumId INT DEFAULT 0;
	DECLARE randomBandId INT DEFAULT 0;
	SELECT Id FROM Albums ORDER BY rand() LIMIT 1 INTO randomAlbumId;
    SELECT Id FROM Bands ORDER BY rand() LIMIT 1 INTO randomBandId ;
    IF(randomAlbumId, randomBandId) NOT IN (SELECT Albums_Id, Bands_Id FROM Albumreleases)
    THEN 
    INSERT INTO Albumreleases (Albums_Id, Bands_id) VALUES (randomAlbumId, randomBandId);
    SET success = 1;
    ELSE
    SET success = 0;
    END IF;
END$$
DELIMITER ;



