USE aptunes;
DELIMITER $$
CREATE DEFINER=`root`@`%` PROCEDURE `MockAlbumRelease`()
BEGIN
	DECLARE randomAlbumId INT DEFAULT 0;
	DECLARE randomBandId INT DEFAULT 0;
	SELECT Id FROM Albums ORDER BY rand() LIMIT 1 INTO randomAlbumId;
    SELECT Id FROM Bands ORDER BY rand() LIMIT 1 INTO randomBandId ;
    IF(randomAlbumId, randomBandId) NOT IN (SELECT Albums_Id, Bands_Id FROM Albumreleases)
    THEN INSERT INTO Albumreleases (Albums_Id, Bands_id) VALUES (randomAlbumId, randomBandId);
    END IF;
END$$
DELIMITER ;